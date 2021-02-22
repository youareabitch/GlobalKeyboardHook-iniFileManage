﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchRCSConfig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            ttbCurrentPath.Text = Environment.CurrentDirectory;
            ttbSourcePath.Text = iniManager.ReadIniFile("Path", "Source", ttbSourcePath.Text);
            ttbDestPath.Text = iniManager.ReadIniFile("Path", "Dest", ttbDestPath.Text);
            ttbWeaponConfigPath.Text = iniManager.ReadIniFile("Path", "WeaponConfig", ttbWeaponConfigPath.Text);
            lblCurrentLoadedConfig.Text += configName;

            //若程式目標沒有config檔案則自行建立
            if (!System.IO.File.Exists($"{Environment.CurrentDirectory}\\config.ini"))
            {
                var newConfig = System.IO.File.Create($"{Environment.CurrentDirectory}\\config.ini");
                newConfig.Close();
                newConfig.Dispose();
                iniManager.WriteIniFile("Path", "Source", ttbSourcePath.Text);
                iniManager.WriteIniFile("Path", "Dest", ttbSourcePath.Text);
            }
        }

        //要用的變數和物件先宣告在這裡
        GlobalKeyboardHook gHook;
        int kv;//將keyValue轉成整數用的變數
        bool ctrl, alt, shift;//按下功能鍵時就改為true
        string configName = "Default";

        //config Manager宣告
        IniManager iniManager = new IniManager($"{Environment.CurrentDirectory}\\config.ini");

        //在Load事件裡要先載入
        private void Form1_Load(object sender, EventArgs e)
        {
            gHook = new GlobalKeyboardHook(); //根據作者的程式碼(class)創造一個新物件

            gHook.KeyDown += new KeyEventHandler(gHook_KeyDown);// 連結KeyDown事件

            foreach (Keys key in Enum.GetValues(typeof(Keys)))
                gHook.HookedKeys.Add(key);

            gHook.hook();//開始監控
        }

        private void ttbSourcePath_TextChanged(object sender, EventArgs e)
        {
            iniManager.WriteIniFile("Path", "Source", ttbSourcePath.Text);
        }

        private void ttbDestPath_TextChanged(object sender, EventArgs e)
        {
            iniManager.WriteIniFile("Path", "Dest", ttbDestPath.Text);
        }

        private void ttbWeaponConfigPath_TextChanged(object sender, EventArgs e)
        {
            iniManager.WriteIniFile("Path", "WeaponConfig", ttbWeaponConfigPath.Text);
        }

        //把按下按鍵後要觸發的事件寫在這裡
        public void gHook_KeyDown(object sender, KeyEventArgs e)
        {
            kv = e.KeyValue;//把按下的按鍵號碼轉成整數存在kv中

            label1.Text = $"目前按下的按鍵號碼：{kv.ToString()}";

            switch (kv)
            {
                case 49://按下1
                    {
                        string fileName = "config1.ini";
                        lblCurrentWeapon.Text = "主武器";
                        CopyFile(ttbSourcePath.Text + $"\\{configName}", ttbDestPath.Text, fileName);
                        break;
                    }
                case 50://按下2
                    {
                        string fileName = "config2.ini";
                        lblCurrentWeapon.Text = "副武器";
                        CopyFile(ttbSourcePath.Text + $"\\{configName}", ttbDestPath.Text, fileName);
                        break;
                    }
                case 51://按下3
                    {
                        string fileName = "config3.ini";
                        lblCurrentWeapon.Text = "For腎上腺素";
                        CopyFile(ttbSourcePath.Text + $"\\{configName}", ttbDestPath.Text, fileName);
                        break;
                    }
                case 96://按下九宮格0
                    {
                        configName = "Default";
                        lblCurrentWeapon.Text = "主武器";
                        SwitchHeroConfig(configName);

                        break;
                    }
                case 97://按下九宮格1
                    {
                        configName = "Twitch";
                        lblCurrentWeapon.Text = "主武器";
                        SwitchHeroConfig(configName);
                        break;
                    }
                case 98://按下九宮格2
                    {
                        configName = "Hibana";
                        lblCurrentWeapon.Text = "主武器";
                        SwitchHeroConfig(configName);
                        break;
                    }
                case 99://按下九宮格3
                    {
                        configName = "Jaeger";
                        lblCurrentWeapon.Text = "主武器";
                        SwitchHeroConfig(configName);
                        break;
                    }
                case 100://按下九宮格4
                    {
                        configName = "Echo";
                        lblCurrentWeapon.Text = "主武器";
                        SwitchHeroConfig(configName);
                        break;
                    }
                case 101://按下九宮格5
                    {
                        configName = "Frost";
                        SwitchHeroConfig(configName);
                        break;
                    }
                case 102://按下九宮格6
                    {
                        configName = "Pulse";
                        lblCurrentWeapon.Text = "主武器";
                        SwitchHeroConfig(configName);
                        break;
                    }
                case 103://按下九宮格7
                    {
                        configName = "Sledge";
                        lblCurrentWeapon.Text = "主武器";
                        SwitchHeroConfig(configName);
                        break;
                    }
                case 104://按下九宮格8
                    {
                        configName = "Vigil";
                        lblCurrentWeapon.Text = "主武器";
                        SwitchHeroConfig(configName);
                        break;
                    }
                case 105://按下九宮格9
                    {
                        configName = "Maverick";
                        lblCurrentWeapon.Text = "主武器";
                        SwitchHeroConfig(configName);
                        break;
                    }
            }
        }

        private void btnLoadWeaponConfig_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = ttbWeaponConfigPath.Text;
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            foreach (var item in openFileDialog1.FileNames)
            {
                IniManager loadedConfig = new IniManager(item);
                IniManager usedConfig;

                if (Convert.ToBoolean(loadedConfig.ReadIniFile("type", "isMain", "true")))
                    usedConfig = new IniManager(ttbSourcePath.Text + "\\Default\\config1.ini");
                else
                    usedConfig = new IniManager(ttbSourcePath.Text + "\\Default\\config2.ini");

                usedConfig.WriteIniFile("first", "y", loadedConfig.ReadIniFile("config", "y", "0"));
                usedConfig.WriteIniFile("first", "rate", loadedConfig.ReadIniFile("config", "rate1", "0"));
                usedConfig.WriteIniFile("second", "y", 0);
                usedConfig.WriteIniFile("second", "rate", loadedConfig.ReadIniFile("config", "rate2", "0"));
            }
        }

        private void CopyFile(string sourcePath, string destPath, string fileName)
        {
            if (System.IO.Directory.Exists(sourcePath))
            {
                // Use Path class to manipulate file and directory paths.
                string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
                string destFile = System.IO.Path.Combine(destPath, "settings.ini");

                IniManager loadedConfig = new IniManager(sourceFile);
                IniManager usingConfig = new IniManager(destFile);

                usingConfig.WriteIniFile("first", "y", loadedConfig.ReadIniFile("first", "y", "0"));
                usingConfig.WriteIniFile("first", "rate", loadedConfig.ReadIniFile("first", "rate", "0"));
                usingConfig.WriteIniFile("second", "y", loadedConfig.ReadIniFile("second", "y", "0"));
                usingConfig.WriteIniFile("second", "rate", loadedConfig.ReadIniFile("second", "rate", "0"));
            }
        }

        private void SwitchHeroConfig(string configName)
        {
            lblCurrentLoadedConfig.Text = lblCurrentLoadedConfig.Text.Substring(0, lblCurrentLoadedConfig.Text.IndexOf("：") + 1);
            lblCurrentLoadedConfig.Text += configName;
            string fileName = "config1.ini";
            CopyFile(ttbSourcePath.Text + $"\\{configName}", ttbDestPath.Text, fileName);
        }
    }
}

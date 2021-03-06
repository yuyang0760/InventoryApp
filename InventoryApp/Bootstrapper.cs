﻿
using System.Windows;
using Prism.Modularity;
using Microsoft.Practices.Unity;
using Prism.Unity;

using System.IO;
using InventoryApp.Views;
using Prism.Mvvm;
using System.Reflection;
using System;
using Prism.Logging;

namespace InventoryApp
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
 
        }

        protected override void ConfigureModuleCatalog()
        {
            var moduleCatalog = (ModuleCatalog)ModuleCatalog;
            moduleCatalog.AddModule(typeof(ModuleSetting.ModuleSettingModule));
            moduleCatalog.AddModule(typeof(ModulePurchase.ModulePurchaseModule));
            moduleCatalog.AddModule(typeof(ModuleRetail.ModuleRetailModule));
            moduleCatalog.AddModule(typeof(ModuleWholesale.ModuleWholesaleModule));
            //moduleCatalog.AddModule(typeof(ModuleSellModule));

            

        }
        
        //protected override IModuleCatalog CreateModuleCatalog()
        //{
        //    return new DirectoryModuleCatalog() { ModulePath = @".\Modules" };
        //}

    }
}


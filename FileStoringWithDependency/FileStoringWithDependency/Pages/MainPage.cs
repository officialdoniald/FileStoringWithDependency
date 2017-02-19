using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FileStoringWithDependency.Pages
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            DependencyService.Get<IFileStoreAndLoad.IFileStoreAndLoad>().SaveText("filename.txt","text");
            
            string loadedText = DependencyService.Get<IFileStoreAndLoad.IFileStoreAndLoad>().LoadText("filename.txt");

            Content = new StackLayout
            {
                Children = {
                    new Label { Text = loadedText }
                }
            };
        }
    }
}

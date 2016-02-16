﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MaterialUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void SplitView_PaneClosed(SplitView sender, object args)
        {
            containerOverlay.Visibility = Visibility.Collapsed;
        }

        private void menuToggleButton_Click(object sender, RoutedEventArgs e)
        {
            mainContainer.IsPaneOpen = !mainContainer.IsPaneOpen;
            if (mainContainer.IsPaneOpen)
            {
                containerOverlay.Visibility = Visibility.Visible;
            }
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            mainContainer.IsPaneOpen = false;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FirstDraft.ApplyDemo.Views
{
    /// <summary>
    /// Interaction logic for ApplyToggleButtonView.xaml
    /// </summary>
    public partial class ApplyToggleButtonView : FirstDraft.Controls.AnimatableUserControl
    {
        public ApplyToggleButtonView()
        {
            InitializeComponent();
            LoadedAnimateDirection = AttachedProperties.AnimationDirection.Left;
        }
    }
}

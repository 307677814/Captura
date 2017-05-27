﻿using Captura.Properties;
using System.Windows;
using WPFCustomMessageBox;

namespace Captura.Models
{
    public class MessageProvider : IMessageProvider
    {
        public void ShowError(string Message)
        {
            CustomMessageBox.ShowOK(Message, Resources.ErrorOccured, Resources.Ok, MessageBoxImage.Error);
        }

        public bool ShowYesNo(string Message, string Title)
        {
            return CustomMessageBox.ShowYesNo(Message, Title, Resources.Yes, Resources.No, MessageBoxImage.Warning) == MessageBoxResult.Yes;
        }
    }
}

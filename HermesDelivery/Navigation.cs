using System;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace HermesDelivery.Common
{
    public static class Navigation
    {
        private static Stack<object> _history = new Stack<object>();


        public static void GoToPage(string dest, object param = null)
        {
            Frame rootFrame = GetRootFrame();
            Type type = GetPageType(dest);

            _history.Push(param);
            rootFrame.Navigate(type);
        }

        public static void GoBack()
        {
            Frame rootFrame = GetRootFrame();

            if (rootFrame.CanGoBack)
            {
                _history.Pop();
                rootFrame.GoBack();
            }
        }

        public static void GoBack(object param = null)
        {
            Frame rootFrame = GetRootFrame();

            if (rootFrame.CanGoBack)
            {
                _history.Pop();
                _history.Pop();
                _history.Push(param);

                rootFrame.GoBack();
            }
        }


        public static T GetParameter<T>()
        {
            if (_history.Count == 0)
            {
                //throw new NoParameterException();
            }

            //try
            //{
            T converted = (T)_history.Peek();
            //_parameter = null;
            return converted;
            //}
            //catch
            //{
            //    throw new UnableToConvertParameterException();
            //}

        }


        private static Frame GetRootFrame()
        {
            return Window.Current.Content as Frame;
        }


        private static Type GetPageType(string page, string pageNameSpace = "HermesDelivery.View")
        {
            Type type = Type.GetType(pageNameSpace + "." + page);

            return type;
        }

    }



}
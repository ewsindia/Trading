using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SmartTrading.Helper
{
    public class Validator
    {
        static string msgEmpty = "This field canot be empty!";
        static string msgItemSelected = "Please select atleast one item from list!";
        static string msgMobile = "Please enter valid mobile!";
        static string msgNumber = "Invalid number format!";
        
        /// <summary>
        ///  Check that is TextBox is empty or not
        /// </summary>
        /// <param name="obj">TexBox object</param>
        /// <param name="err">erro object</param>
        /// <param name="message">optional</param>
        /// <returns></returns>
        public static bool isEmpty(ref TextBox obj, ref ErrorProvider err, string message = null)
        {
            if (message == null)
                message = msgEmpty;
            if (obj.Text.Length <= 0)
            {
                err.SetError(obj, message);
                return true;
            }
            else
            {
                err.SetError(obj, "");
                return false;
            }

        }

        /// <summary>
        ///  Check that is TextBox is empty or not
        /// </summary>
        /// <param name="obj">TexBox object</param>
        /// <param name="err">erro object</param>
        /// <param name="message">optional</param>
        /// <returns></returns>
        public static bool isEmpty( TextBox obj,  ErrorProvider err, string message = null)
        {
            if (message == null)
                message = msgEmpty;
            if (obj.Text.Length <= 0)
            {
                err.SetError(obj, message);
                return true;
            }
            else
            {
                err.SetError(obj, "");
                return false;
            }

        }

        /// <summary>
        ///  Check that is ComboBox is empty or not
        /// </summary>
        /// <param name="obj">ComboBox object</param>
        /// <param name="err">erro object</param>
        /// <param name="message">optional message for display</param>
        /// <returns></returns>
        public static bool isEmpty(ref ComboBox obj, ref ErrorProvider err, string message = null)
        {
            if (message == null)
                message = msgEmpty;
            if (obj.Text.Length <= 0)
            {
                err.SetError(obj, message);
                return true;
            }
            else
            {
                err.SetError(obj, "");
                return false;
            }

        }

        /// <summary>
        ///  Check that is ComboBox is empty or not
        /// </summary>
        /// <param name="obj">ComboBox object</param>
        /// <param name="err">erro object</param>
        /// <param name="message">optional message for display</param>
        /// <returns></returns>
        public static bool isEmpty( ComboBox obj,  ErrorProvider err, string message = null)
        {
            if (message == null)
                message = msgEmpty;
            if (obj.Text.Length <= 0)
            {
                err.SetError(obj, message);
                return true;
            }
            else
            {
                err.SetError(obj, "");
                return false;
            }

        }
        /// <summary>
        ///  Check that is ComboBox is empty or not
        /// </summary>
        /// <param name="obj">ComboBox object</param>
        /// <param name="err">erro object</param>
        /// <param name="message">optional message for display</param>
        /// <returns></returns>
        public static bool isNumber(ref TextBox obj, ref ErrorProvider err, string message = null)
        {
            if (obj.Text.Length == 0)
            {
                err.SetError(obj, "");
                return true;
            }
            if (message == null)
                message = msgNumber;
            try{
                Convert.ToDouble(obj.Text);
                err.SetError(obj, "");
                return true;
            }
            catch (Exception e)
            {
                err.SetError(obj, message);
                return false;
            }

        }

        /// <summary>
        ///  Check that is ComboBox is empty or not
        /// </summary>
        /// <param name="obj">ComboBox object</param>
        /// <param name="err">erro object</param>
        /// <param name="message">optional message for display</param>
        /// <returns></returns>
        public static bool isNumber( TextBox obj,  ErrorProvider err, string message = null)
        {
            if (obj.Text.Length == 0)
                return true;
            if (message == null)
                message = msgNumber;
            try
            {
                Convert.ToDouble(obj.Text);
                err.SetError(obj, "");
                return true;
            }
            catch (Exception e)
            {
                err.SetError(obj, message);
                return false;
            }

        }

        /// <summary>
        ///  Check that is one or more ListBox items are selected or not
        /// </summary>
        /// <param name="obj">ComboBox object</param>
        /// <param name="err">erro object</param>
        /// <param name="message">optional message for display</param>
        /// <returns></returns>
        public static bool isItemSelected(ref ListBox obj, ref ErrorProvider err, string message = null)
        {
            if (message == null)
                message = msgItemSelected;
            if (obj.SelectedItems.Count <= 0)
            {
                err.SetError(obj, message);
                return false;
            }
            else
            {
                err.SetError(obj, "");
                return true;
            }

        }
        /// <summary>
        ///  Check that is one or more ListBox items are selected or not
        /// </summary>
        /// <param name="obj">ComboBox object</param>
        /// <param name="err">erro object</param>
        /// <param name="message">optional message for display</param>
        /// <returns></returns>
        public static bool isItemSelected( ListBox obj,  ErrorProvider err, string message = null)
        {
            if (message == null)
                message = msgItemSelected;
            if (obj.SelectedItems.Count <= 0)
            {
                err.SetError(obj, message);
                return false;
            }
            else
            {
                err.SetError(obj, "");
                return true;
            }

        }
   
       

        /// <summary>
        ///  Check that is one or more ListBox items are selected or not
        /// </summary>
        /// <param name="obj">ComboBox object</param>
        /// <param name="err">erro object</param>
        /// <param name="message">optional message for display</param>
        /// <returns></returns>
        public static bool isMobile(ref TextBox obj, ref ErrorProvider err, string message = null)
        {
            if (message == null)
                message = msgMobile;
            if (obj.Text.Length != 10)
            {
                err.SetError(obj, message);
                return false;
            }
            else
            {
                err.SetError(obj, "");
                return true;
            }

        }

        /// <summary>
        ///  Check that is one or more ListBox items are selected or not
        /// </summary>
        /// <param name="obj">ComboBox object</param>
        /// <param name="err">erro object</param>
        /// <param name="message">optional message for display</param>
        /// <returns></returns>
        public static bool isMobile( TextBox obj,  ErrorProvider err, string message = null)
        {
            if (message == null)
                message = msgMobile;
            if (obj.Text.Length != 10)
            {
                err.SetError(obj, message);
                return false;
            }
            else
            {
                err.SetError(obj, "");
                return true;
            }

        }

        public static bool isText(ref Object obj, ref ErrorProvider err, string message = "This field is required!")
        {
            
             MessageBox.Show( obj.GetType().Name);
          
                 
             switch (obj.GetType().Name)
             {
                 case "TextBox": 
                     var t = (TextBox)obj;
                     err.SetError(t, message);
                     break;
                 case "ComboBox": break;

             }
             
            return true;

        }


        public static bool isText( Object obj,  ErrorProvider err, string message = "This field is required!")
        {

            MessageBox.Show(obj.GetType().Name);


            switch (obj.GetType().Name)
            {
                case "TextBox":
                    var t = (TextBox)obj;
                    err.SetError(t, message);
                    break;
                case "ComboBox": break;

            }

            return true;

        }

       
    }
}

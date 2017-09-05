using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace UXIFramework
{
    public class UXImplementer
    {
        public void Implement(object F, string AppName)
        {
            try
            {
                string UXName = "UXDefinition";
                if (!System.IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\UXI Themes"))
                    System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\UXI Themes");
                try
                {
                    Page P = (Page)F;
                    UXName += "Web";
                    AppName += "Web";
                }
                catch (Exception)
                {

                    
                }
                string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\UXI Themes\\" + AppName + "\\" + UXName + ".dll";
                Assembly dll = Assembly.LoadFile(Path); //DALL name of your assembly 
                Type MyLoadClass = dll.GetType(AppName + "." + "UXMainClass"); // name of your class 
                if (MyLoadClass != null)
                {
                    MethodInfo methodInfo = MyLoadClass.GetMethod("UXInit");
                    if (methodInfo != null)
                    {
                        object result = null;
                        ParameterInfo[] parameters = methodInfo.GetParameters();
                        object classInstance = Activator.CreateInstance(MyLoadClass, null);
                        if (parameters.Length == 0)
                        {
                            result = methodInfo.Invoke(classInstance, null);
                        }
                        else
                        {
                            object[] parametersArray = new object[] { F };// parametreleri buraya ekle

                            result = methodInfo.Invoke(classInstance, parametersArray);
                        }
                    }
                }
            }
            catch (Exception)
            {
                 
            }
        }

    }
}

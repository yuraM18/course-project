using Common.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestingInfo.Data;
using TestingInfo.FormsEditor.Controllers;
using TestingInfo.FormsEditor.Editors;
using TestingInfo.FormsEditor.Selector;

namespace TestingInfo.FormsEditor
{
    static class Program
    {
        static FMain fMain;
        static DataContext dataContext;
        static FTestResultSelector testResultSelector;
        static FSelector testSelector;
        static TestsController testsController;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FMain());
            dataContext = new DataContext();
            testSelector = new FSelector(dataContext.Tests);
            testResultSelector = new FTestResultSelector(dataContext);
            testsController = new TestsController(dataContext, testSelector);
            dataContext.Load();

            fMain = new FMain()
            {
                DataContext = dataContext,
                TestsSelector = testSelector,
                TestResultSelector = testResultSelector
            };
            Application.Run(fMain);
        }
    }
}

using GalaSoft.MvvmLight;
using ProjektPazigFramework.Model;
using ProjektPazigFramework.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjektPazigFramework.ViewModel
{
   
    class MainViewModel //: ViewModelBase
    {
        
         public IList<Person> PersonList { get; set; }
            ApplicationDb _db = new ApplicationDb();
        public MainViewModel()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory",
            Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));
            PersonList = _db.People.ToList();
           
        }
    }
}
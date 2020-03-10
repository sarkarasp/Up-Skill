using DemoProject.xm.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DemoProject.xm.ViewModels
{
   public class TutorialListPageViewModel
    {
        public ObservableCollection<TutorialListModel> TutorialList { get; set; }

        public TutorialListPageViewModel()
        {
            TutorialList = new ObservableCollection<TutorialListModel>();
            TutorialList.Add(new TutorialListModel { Name = "Introduction to C#", Image = "csharpDashboard.png", Detail = "C# is a simple & powerful object-oriented programming language developed by Microsoft. ", Ingredients = "C# could theoretically be compiled to machine code, but in real life, it's always used in combination with the .NET framework. Therefore, applications written in C#, requires the .NET framework to be installed on the computer running the application. While the .NET framework makes it possible to use a wide range of languages, C# is sometimes referred to as THE .NET language, perhaps because it was designed together with the framework. +'<br>' + Our Show C# tool makes it easy to learn C#, it shows both the code and the result." });
            TutorialList.Add(new TutorialListModel { Name = "Environment Setup", Image = "csharpDashboard.png", Detail = "C# is used for server side execution for different kind of application like web, window forms or console etc.", Ingredients = "This is our detail page details to be listed" });
            TutorialList.Add(new TutorialListModel { Name = "Version History", Image = "csharpDashboard.png", Detail = "This is introduction to C# programming language", Ingredients = "This is our detail page details to be listed" });
            TutorialList.Add(new TutorialListModel { Name = "First C# Program", Image = "csharpDashboard.png", Detail = "This is introduction to C# programming language", Ingredients = "This is our detail page details to be listed" });
            TutorialList.Add(new TutorialListModel { Name = "C# - Basic Syntax", Image = "csharpDashboard.png", Detail = "This is introduction to C# programming language", Ingredients = "This is our detail page details to be listed" });
            TutorialList.Add(new TutorialListModel { Name = "Data Types", Image = "csharpDashboard.png", Detail = "This is introduction to C# programming language", Ingredients = "This is our detail page details to be listed" });
            TutorialList.Add(new TutorialListModel { Name = "Variables", Image = "csharpDashboard.png", Detail = "This is introduction to C# programming language", Ingredients = "This is our detail page details to be listed" });
            TutorialList.Add(new TutorialListModel { Name = "Declare Constant in C#", Image = "csharpDashboard.png", Detail = "This is introduction to C# programming language", Ingredients = "This is our detail page details to be listed" });
            TutorialList.Add(new TutorialListModel { Name = "Types of Operatorts in C#", Image = "csharpDashboard.png", Detail = "This is introduction to C# programming language", Ingredients = "This is our detail page details to be listed" });
            TutorialList.Add(new TutorialListModel { Name = "Decesion Making -IF..Else", Image = "csharpDashboard.png", Detail = "This is introduction to C# programming language", Ingredients = "This is our detail page details to be listed" });
        }
    }
}

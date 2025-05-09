// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/runner/workspace/BlazorApp/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/runner/workspace/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/runner/workspace/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/runner/workspace/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/runner/workspace/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/runner/workspace/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/runner/workspace/BlazorApp/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/runner/workspace/BlazorApp/_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/runner/workspace/BlazorApp/_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/runner/workspace/BlazorApp/Pages/Index.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/runner/workspace/BlazorApp/Pages/Index.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/resume")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 104 "/home/runner/workspace/BlazorApp/Pages/Index.razor"
       
    private int step = 1;

    // Models
    public class PersonalInfo { public string Name { get; set; } = ""; public string Email { get; set; } = ""; }
    public class Education { public string School { get; set; } = ""; public string Degree { get; set; } = ""; public string Year { get; set; } = ""; }
    public class Experience { public string Company { get; set; } = ""; public string Role { get; set; } = ""; public string Duration { get; set; } = ""; }
    public class SkillModel { public string Skill { get; set; } = ""; }

    // Main Models
    PersonalInfo info = new();
    Education eduInput = new();
    Experience expInput = new();
    SkillModel skillModel = new();

    List<Education> educationList = new();
    List<Experience> experienceList = new();
    List<string> skillList = new();

    void NextStep() => step++;

    void AddEducation()
    {
        educationList.Add(new Education
        {
            School = eduInput.School,
            Degree = eduInput.Degree,
            Year = eduInput.Year
        });

        eduInput = new();
    }

    void AddExperience()
    {
        experienceList.Add(new Experience
        {
            Company = expInput.Company,
            Role = expInput.Role,
            Duration = expInput.Duration
        });

        expInput = new();
    }

    void AddSkill()
    {
        if (!string.IsNullOrWhiteSpace(skillModel.Skill))
        {
            skillList.Add(skillModel.Skill);
            skillModel.Skill = "";
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

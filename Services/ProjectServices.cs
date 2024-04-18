using codewithabkhan.github.io.Models;

namespace codewithabkhan.github.io.Services;

public class ProjectServices : IProjectServices
{
    public List<Project> GetProjects()
    {
        return new List<Project>
        {
            
            new Project
            {
                Name = "My Porfolio Powered by .NET blazor",
                 Started = DateTime.Parse("2024-03-29"),
                Ended =DateTime.Parse("2024-04-16"),
                Description = "My Personal Porfolio build using .NET 8 and ASP.NET Core Blazor WebAssembly",
                Images = new List<ProImage>
                {
                     new ProImage
                    {
                        Src = "images/projects/blazor-dotnet-wasm-portfolio-github.png",
                        Alt = " main page ",
                        Width = 1920,
                        Height = 1080
                    },
                    new ProImage
                    {
                        Src = "images/projects/blazor-dotnet-wasm-portfolio-github-light.png",
                        Alt = " main page ",
                        Width = 1920,
                        Height = 1080
                    }
                },
                Technologies = new List<Technology>
                {
                    new Technology { Name = "NET Core", Icon = "images/icons/net-core.svg" },
                    new Technology { Name = "C#", Icon = "images/icons/csharp.svg" },
                    new Technology { Name = "Blazor .NET 8", Icon = "images/icons/blazor.svg" },
                    new Technology { Name = "Web Assembly", Icon = "images/icons/webassembly.svg" },
                    new Technology { Name = "Github", Icon = "images/icons/github.svg" },
                     new Technology { Name = "VS Code", Icon = "images/icons/vscode.svg" }
                },
                Website = "https://youtu.be/B2TWGlE8noU",
                Github = "https://github.com/CodeWithAbkhan/Blazor-Portfolio"
            },
            new Project
            {
                Name = "Patients Management System",
                Started = DateTime.Parse("2020-02-12"),
                Ended =DateTime.Parse("2022-01-24"),
                Description = "SM Patients Management System: ASP.NET Core Blazor, .NET 8 powered, deployed on Ubuntu 22.04 VPS via Docker. SQL Server image managed within Docker for efficient data handling. Simplifying patient management for healthcare professionals with a secure, user-friendly interface. Stay tuned for updates!",
                Images = new List<ProImage>
                {
                    new ProImage
                    {
                        Src = "images/projects/sm-patients-management-system-project-build-with-aspnet-core-dot-net-8-full-stack-docker-sql-server-image-deployed-on-vps-ubuntu-using-docker.png",
                        Alt = "main page screenshot",
                        Width = 1920,
                        Height = 1080
                    }
                },
                Technologies = new List<Technology>
                {
                    new Technology { Name = "NET Core", Icon = "images/icons/net-core.svg" },
                    new Technology { Name = "C#", Icon = "images/icons/cpp.svg" },
                    new Technology { Name = "Blazor .NET 8", Icon = "images/icons/blazor.svg" },
                    new Technology { Name = "MS SQL SERVER", Icon = "images/icons/sql-server.svg" },
                    new Technology { Name = "Docker", Icon = "images/icons/docker.svg" },
                    new Technology { Name = "Github", Icon = "images/icons/github.svg" },
                    new Technology { Name = "Linux", Icon = "images/icons/linux.svg" }
                },
                Website = null,
                Github = "https://github.com/CodeWithAbkhan/smpatients"
            },
            new Project
            {
                Name = "Static Server Rendering in .NET 8 blazor",
                 Started = DateTime.Parse("2020-02-12"),
                Ended =DateTime.Parse("2022-01-24"),
                Description = "Personal Markdown MD Blog using .NET 8 and ASP.NET Core.100% performance achieved using Latest Blazor Static Server Rendering Featured, using .NET 8 SDK with InteractiveServer None, Search, Pagination and styling with Bootstrap.!",
                Images = new List<ProImage>
                {
                    new ProImage
                    {
                        Src = "images/projects/Blog-using-latest-Blazor-Static-Server-Rendering-Features-Project.png",
                        Alt = " main page ",
                        Width = 1920,
                        Height = 1080
                    }
                },
                Technologies = new List<Technology>
                {
                    new Technology { Name = "NET Core", Icon = "images/icons/net-core.svg" },
                    new Technology { Name = "C#", Icon = "images/icons/cpp.svg" },
                    new Technology { Name = "Blazor .NET 8", Icon = "images/icons/blazor.svg" },
                    new Technology { Name = "Github", Icon = "images/icons/github.svg" }
                },
                Website = "https://youtu.be/B2TWGlE8noU",
                Github = "https://github.com/CodeWithAbkhan/StaticBlogBlazor"
            }
            ,
            new Project
            {
                Name = "Porfolio Build with Next.js 13",
                Started = DateTime.Parse("2023-06-18"),
                Ended =DateTime.Parse("2023-09-21"),
                Description = "Personal Porfolio using  Next js 13 and tailwind css along with new features of Next.js 13 !",
                Images = new List<ProImage>
                {
                    new ProImage
                    {
                        Src = "images/projects/nextjs-portfolio-full.png",
                        Alt = " main porfolio page ",
                        Width = 1920,
                        Height = 1080
                    }
                },
                Technologies = new List<Technology>
                {
                    new Technology { Name = "Next.js", Icon = "images/icons/next.svg" },
                    new Technology { Name = "Tailwindcss", Icon = "images/icons/tailwindcss.svg" },
                    new Technology { Name = "NodeJs", Icon = "images/icons/nodejs.svg" },
                    new Technology { Name = "Github", Icon = "images/icons/github.svg" }
                },
                Website = null,
                Github = "https://github.com/CodeWithAbkhan/portfolio"
            },
            new Project
            {
                Name = "Static Server Rendering in .NET 8 blazor",
                 Started = DateTime.Parse("2020-02-12"),
                Ended =DateTime.Parse("2022-01-24"),
                Description = "Personal Markdown MD Blog using .NET 8 and ASP.NET Core.100% performance achieved using Latest Blazor Static Server Rendering Featured, using .NET 8 SDK with InteractiveServer None, Search, Pagination and styling with Bootstrap.!",
                Images = new List<ProImage>
                {
                    new ProImage
                    {
                        Src = "images/projects/Blog-using-latest-Blazor-Static-Server-Rendering-Features-Project.png",
                        Alt = " main page ",
                        Width = 1920,
                        Height = 1080
                    }
                },
                Technologies = new List<Technology>
                {
                    new Technology { Name = "NET Core", Icon = "images/icons/net-core.svg" },
                    new Technology { Name = "C#", Icon = "images/icons/cpp.svg" },
                    new Technology { Name = "Blazor .NET 8", Icon = "images/icons/blazor.svg" },
                    new Technology { Name = "Github", Icon = "images/icons/github.svg" }
                },
                Website = "https://youtu.be/B2TWGlE8noU",
                Github = "https://github.com/CodeWithAbkhan/StaticBlogBlazor"
            },
            new Project
            {
                Name = "Personal Blog Build with Hugo - Static Site Generator",
                 Started = DateTime.Parse("2018-04-02"),
                Ended =DateTime.Parse("2018-06-27"),
                Description = "I Build my personal blog with hugo static site generator,  achieved 100% performance and SEO, even with Adsense display!",
                Images = new List<ProImage>
                {
                    new ProImage
                    {
                        Src = "images/projects/sqlpey-build-using-hugo-static-site-generation.png",
                        Alt = " main landing page ",
                        Width = 1920,
                        Height = 1080
                    }
                },
                Technologies = new List<Technology>
                {
                    new Technology { Name = "Hugo", Icon = "images/icons/hugo.svg" },
                    new Technology { Name = "Go", Icon = "images/icons/go.svg" },
                    new Technology { Name = "HTML", Icon = "images/icons/html.svg" },
                    new Technology { Name = "CSS", Icon = "images/icons/css.svg" },
                    new Technology { Name = "Javascript", Icon = "images/icons/javascript.svg" },
                },
                Website = "https://sqlpey.com",
                Github = null
            },
            new Project
            {
                Name = "Build Complete Database Project for Inventory Management System",
                 Started = DateTime.Parse("2020-03-12"),
                Ended =DateTime.Parse("2020-03-13"),
                Description = "I Create Complete Database schema, ERD, Database Diagrams & Queries for  for Inventory Management System!",
                Images = new List<ProImage>
                {
                    new ProImage
                    {
                        Src = "images/projects/database-schema-inventory.png",
                        Alt = " main landing page ",
                        Width = 1920,
                        Height = 1080
                    }
                },
                Technologies = new List<Technology>
                {
                    new Technology { Name = "sql server", Icon = "images/icons/sql-server.svg" },
                    new Technology { Name = "database", Icon = "images/icons/database.svg" },
                    new Technology { Name = "flow diagram", Icon = "images/icons/flow.svg" }
                },
                Website = null,
                Github = null
            }
            ,
            new Project
            {
                Name = "Build Complete Database Project for 3D Printing App",
                 Started = DateTime.Parse("2020-02-12"),
                Ended =DateTime.Parse("2022-01-24"),
                Description = "I Create and Build Complete Database schema, Flowchart, Sequence, UML, Use Case, ERD, Database Diagrams & Queries for 3D printing App!",
                Images = new List<ProImage>
                {
                    new ProImage
                    {
                        Src = "images/projects/db2.png",
                        Alt = " main landing page ",
                        Width = 1920,
                        Height = 1080
                    },
                    new ProImage
                    {
                        Src = "images/projects/flow-diagram.png",
                        Alt = " main landing page ",
                        Width = 1920,
                        Height = 1080
                    }
                },
                Technologies = new List<Technology>
                {
                    new Technology { Name = "sql server", Icon = "images/icons/sql-server.svg" },
                    new Technology { Name = "database", Icon = "images/icons/database.svg" },
                    new Technology { Name = "flow diagram", Icon = "images/icons/flow.svg" }
                },
                Website = null,
                Github = null
            },
            new Project
            {
                Name = "Build and Deploy Static Website for Welfare Organization PANAH",
                 Started = DateTime.Parse("2018-04-02"),
                Ended =DateTime.Parse("2018-06-27"),
                Description = "I Build Complete Static Webiste for Welfare organization using HTML, CSS, and javascript and styled with Bootstrap and deployed on server !",
                Images = new List<ProImage>
                {
                    new ProImage
                    {
                        Src = "images/projects/panah-html-css-js-bootstrap-landing-page.png",
                        Alt = " main landing page ",
                        Width = 1920,
                        Height = 1080
                    }
                },
                Technologies = new List<Technology>
                {
                    new Technology { Name = "HTML", Icon = "images/icons/html.svg" },
                    new Technology { Name = "CSS", Icon = "images/icons/css.svg" },
                    new Technology { Name = "Javascript", Icon = "images/icons/javascript.svg" },
                    new Technology { Name = "VS Code", Icon = "images/icons/vscode.svg" }
                },
                Website = "https://panah.org.pk",
                Github = null
            }

        };
    }
}
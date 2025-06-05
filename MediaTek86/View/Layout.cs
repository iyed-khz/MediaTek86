using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.LinkLabel;

namespace MediaTek86.View
{
    public class Layout
    {
        <!DOCTYPE html>
<html lang = "fr" >
< head >
    < meta charset="utf-8" />
    <meta name = "viewport" content="width=device-width, initial-scale=1.0" />
    <title>@ViewData["Title"] - MediaTek86</title>
    <link rel = "stylesheet" href="~/lib/bootstrap/dist/css/bootstrap.min.css" /> <link rel = "stylesheet" href="~/css/site.css" asp-append-version="true" />
    </head>
<body>
    <header>
        <nav class="navbar navbar-expand-sm navbar-toggleable-sm navbar-dark bg-primary border-bottom box-shadow mb-3">
            <div class="container-fluid">
                <a class="navbar-brand" asp-area="" asp-controller="Home" asp-action="Index">MediaTek86</a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target=".navbar-collapse" aria-controls="navbarSupportedContent"
                        aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="navbar-collapse collapse d-sm-inline-flex justify-content-between">
                    <ul class="navbar-nav flex-grow-1">
                        <li class="nav-item">
                            <a class="nav-link text-light" asp-area="" asp-controller="Home" asp-action="Index">Accueil</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link text-light" asp-area="" asp-controller="Personnel" asp-action="List">Gestion Personnel</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link text-light" asp-area="" asp-controller="Absences" asp-action="List">Gestion Absences</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link text-light" asp-area="" asp-controller="Auth" asp-action="Logout">Déconnexion</a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
    </header>

    <div class="container">
        <main role = "main" class="pb-3">
            @RenderBody() </main>
    </div>

    <footer class="border-top footer text-muted">
        <div class="container">
            &copy; @DateTime.Now.Year - MediaTek86.Tous droits réservés.
        </Div>
    }
}

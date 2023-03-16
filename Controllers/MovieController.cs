using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dotnet.Models;

namespace dotnet.Controllers;

public class MovieController : Controller {
    // Get /Movies/Random/
    public IActionResult Random() {
        Movie movie = new Movie() {Name = "The Pope's Exorcist"};
        return View(movie);
    }

    public IActionResult Edit(int id) {
        return Content("id " + id);
    }

    // movies
    public IActionResult Index(int? pageIndex, string sortBy) {
        if (! pageIndex.HasValue) {
            pageIndex = 1;
        }
        if (string.IsNullOrWhiteSpace(sortBy)) {
            sortBy = "Name";
        }

        return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
    }

    public IActionResult ByReleaseYear(int year, int month) {
        return Content(year + "/" + month);
    }
}

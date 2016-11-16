using System.Collections.Generic;
using Nancy;
using Parcel.Objects;

namespace Parcel
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add_new_package.cshtml"];
      Get["/view_all_packages"] = _ =>
      {
        List<Package> _instance = Package.GetAll();
        return View["view_all_packages", _instance];
      };
      Post["/package_added"] = _ =>
      {
        Package newPackage = new Package(int.Parse(Request.Form["new-Weight"]),  int.Parse(Request.Form["new-Height"]),  int.Parse(Request.Form["new-Length"]),  int.Parse(Request.Form["new-Width"]));
        newPackage.Save();
        return View["package_added.cshtml", newPackage];
      };
      Post["/packages_cleared"] = _ =>
      {
        Package.ClearAll();
        return View["packages_cleared.cshtml"];
      };
    }
  }
}

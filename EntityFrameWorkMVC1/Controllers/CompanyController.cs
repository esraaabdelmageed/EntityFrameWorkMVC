using Microsoft.AspNetCore.Mvc;
using EntityFrameWorkMVC1.Context;
using EntityFrameWorkMVC1.Models;
using Microsoft.EntityFrameworkCore;
namespace EntityFrameWorkMVC1.Controllers;


public class CompanyController : Controller
{
    private readonly CompanyContext companyContext;
    public CompanyController(CompanyContext context) 
    { 
        this.companyContext = context;
    }
    public IActionResult Index()
    {   
        var data= companyContext.Company.ToList();
        return View(data);
    }
    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Add(Company company)
    {
        if (ModelState.IsValid)
        { 
          companyContext.Company.Add(company);
          companyContext.SaveChanges();
          return RedirectToAction("Index");
        
        }
        return View(company);
    
    
    }
    [HttpGet]
    public IActionResult Details(int id)
    {
        var company = companyContext.Company.Find(id);
        if (company == null) return NotFound();

        return View(company);

    }
    [HttpGet]
    public IActionResult Delete(int?id)
    {
        var company = companyContext.Company.Find(id);
        if (company == null)
            return NotFound();

        return View(company);
    }
    [HttpPost ]
    public IActionResult Delete(int id)
    {

        var company = companyContext.Company.Find(id);
        if (company == null)
        { return NotFound(); }
        companyContext.Company.Remove(company);
        companyContext.SaveChanges();
        return RedirectToAction("Index");

    }
    [HttpGet]
    public IActionResult Update(int id)
    {
        var company = companyContext.Company.Find(id);
        if (company == null)
            return NotFound();

        return View(company);

    }
    [HttpPost]
    public ActionResult Update(Company company)
    {
        if (ModelState.IsValid) {
            companyContext.Entry(company).State = EntityState.Modified;
            companyContext.SaveChanges();
            return RedirectToAction("Index");

        
        
        }
        return View(company);
    }


}

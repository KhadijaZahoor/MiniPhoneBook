﻿using System;
using Assignment5.Models;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment5.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            PhoneBookDbEntities db = new PhoneBookDbEntities();
            List<PersonModel> list = new List<PersonModel>();
            var dblist = db.Person.ToList();
            foreach (var i in dblist)
            {
                PersonModel p = new PersonModel();
                p.PersonId = i.PersonId;
                p.FirstName = i.FirstName;
                p.MiddleName = i.MiddleName;
                p.LastName = i.LastName;
                p.DateOfBirth = Convert.ToDateTime(i.DateOfBirth);
                p.AddedOn = Convert.ToDateTime(i.AddedOn);
                p.AddedBy = User.Identity.GetUserId();
                p.FaceBookAccountId = i.FaceBookAccountId;
                p.EmailId = i.EmailId;
                p.ImagePath = i.ImagePath;
                p.LlinkedInId = i.LinkedInId;
                p.TwitterId = i.TwitterId;
                p.HomeCity = i.HomeCity;
                p.HomeAddress = i.HomeAddress;
                list.Add(p);
            }

            return View(list);
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(PersonModel collection)
        {
            try
            {
                // TODO: Add insert logic here
                PhoneBookDbEntities db = new PhoneBookDbEntities();

                Person p = new Person();
                p.FirstName = collection.FirstName;
                p.MiddleName = collection.MiddleName;
                p.LastName = collection.LastName;
                p.DateOfBirth = collection.DateOfBirth;
                p.AddedBy = User.Identity.GetUserId();
                p.AddedOn = collection.AddedOn;
                p.HomeAddress = collection.HomeAddress;
                p.HomeCity = collection.HomeCity;
                p.FaceBookAccountId = collection.FaceBookAccountId;
                p.LinkedInId = collection.LlinkedInId;
                p.UpdateOn = Convert.ToDateTime(collection.UpdateOn);
                p.ImagePath = collection.ImagePath;
                p.TwitterId = collection.TwitterId;
                p.EmailId = collection.EmailId;
                db.Person.Add(p);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Person/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Person/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

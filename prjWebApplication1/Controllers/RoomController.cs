using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using prjWebApplication1.Models;
using prjWebApplication1.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace prjWebApplication1.Controllers
{
    public class RoomController : Controller
    {
        private IWebHostEnvironment _enviro;
        public RoomController(IWebHostEnvironment p)
        {
            _enviro = p;
        }

        public IActionResult List(CKeywordViewModel model)
        {
            MingSuContext db = new MingSuContext();
            IEnumerable<Room> datas = null;
            if (string.IsNullOrEmpty(model.txtKeyword))

                datas = from r in db.Rooms
                        select r;
            else
                datas = db.Rooms.Where(p => p.RoomName.Contains(model.txtKeyword)
                || p.RoomPrice.ToString().Contains(model.txtKeyword)
                || p.RoomIntrodution.Contains(model.txtKeyword)
                || p.MemberId.ToString().Contains(model.txtKeyword)
                || p.RoomstatusId.ToString().Contains(model.txtKeyword)
                || p.Address.Contains(model.txtKeyword)
                || p.CreateDate.ToString().Contains(model.txtKeyword)
                || p.FImagePath.Contains(model.txtKeyword));
            return View(datas);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Room p)
        {
            MingSuContext db = new MingSuContext();
            db.Rooms.Add(p);
            db.SaveChanges();
            return RedirectToAction("List");
        }
        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                MingSuContext db = new MingSuContext();
                Room r = db.Rooms.FirstOrDefault(t => t.RoomId == id);
                if (r != null)
                {
                    db.Rooms.Remove(r);
                    db.SaveChanges();
                }
            }
            return RedirectToAction("List");
        }
        public ActionResult Edit(int? id)
        {
            if (id != null)
            {
                MingSuContext db = new MingSuContext();
                Room c = db.Rooms.FirstOrDefault(t => t.RoomId ==id);
                if (c != null)
                    return View(c);
            }
            return RedirectToAction("List");
        }
        [HttpPost]
        public ActionResult Edit(CRoomViewModel inProd)
        {
            MingSuContext db = new MingSuContext();
            Room c = db.Rooms.FirstOrDefault(t => t.RoomId == inProd.RoomID);
            if (c != null)
            {
                if (inProd.photo != null)
                {
                    string pName = Guid.NewGuid().ToString() + ".jpg";
                    c.FImagePath = pName;
                    string path = _enviro.WebRootPath + "/images/" + pName;
                    inProd.photo.CopyTo(new FileStream(path, FileMode.Create));
                }
                c.RoomName = inProd.RoomName;
                c.RoomPrice = inProd.RoomPrice;
                c.RoomIntrodution = inProd.RoomIntrodution;
                c.Address = inProd.Address;
                c.CreateDate = inProd.CreateDate;
                c.MemberId = inProd.MemberId;
                c.RoomstatusId = inProd.RoomstatusId;

                db.SaveChanges();
            }
            return RedirectToAction("List");
        }








    }
    }

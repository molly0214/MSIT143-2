using Microsoft.AspNetCore.Http;
using prjWebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjWebApplication1.ViewModels
{
    public class CRoomViewModel
    {
        private Room _room;
        public Room room
        {
            get { return _room; }
            set { _room = value; }
        }
        public CRoomViewModel()
        {
            _room = new Room();
        }
        public int RoomID
        {
            get { return _room.RoomId; }
            set { _room.RoomId = value; }
        }
        public string RoomName
        {
            get { return _room.RoomName; }
            set { _room.RoomName = value; }
        }
        public decimal RoomPrice
        {
            get { return _room.RoomPrice; }
            set { _room.RoomPrice = value; }
        }
        public string RoomIntrodution
        {
            get { return _room.RoomIntrodution; }
            set { _room.RoomIntrodution = value; }
        }
        public string Address
        {
            get { return _room.Address; }
            set { _room.Address = value; }
        }
        public int MemberId
        {
            get { return _room.MemberId; }
            set { _room.MemberId = value; }
        }
        public int RoomstatusId
        {
            get { return _room.RoomstatusId; }
            set { _room.RoomstatusId = value; }
        }

        public DateTime? CreateDate
        {
            get { return _room.CreateDate; }
            set { _room.CreateDate = value; }
        }
        public string FImagePath
        {
            get { return _room.FImagePath; }
            set { _room.FImagePath = value; }
        }
        public IFormFile photo { get; set; }



    }
}

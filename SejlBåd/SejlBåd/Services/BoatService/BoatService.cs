﻿using Microsoft.AspNetCore.Routing.Constraints;
using SejlBåd.Models;
using SejlBåd.Pages.BoatPages;

namespace SejlBåd.Services.BoatService
{
    public class BoatService : IBoatService
    {
        private JsonFileBoatService JsonFileBoatService { get; set; }
        private JsonFileBoatListService _jsonFileBoatListService;

        List<Boat> boats;
        List<Boats> boatList;


        public BoatService(JsonFileBoatService jsonFileBoatService, JsonFileBoatListService jsonFileBoatListService)
        {
            JsonFileBoatService = jsonFileBoatService;
            _jsonFileBoatListService = jsonFileBoatListService;
            boats = JsonFileBoatService.GetJsonBoats().ToList();
            boatList = _jsonFileBoatListService.GetJsonBoats().ToList();
        }

        Boat IBoatService.RentBoat(int id, Boat boat, Account account)
        {
            foreach(var b in boatList[id - 1].BoatList)
            {
                if(b.Booked == false && b.Id == boat.Id)
                {
                    b.Booked = true;
                    b.Account = account;
                    _jsonFileBoatListService.SaveJsonBoats(boatList);
                    return b;
                }
            }
            return null;
        }


        public void AddBoats(int id, Boat boat)
        {
            boats.Add(boat);
            boatList[id - 1].BoatList.Add(boat);
            _jsonFileBoatListService.SaveJsonBoats(boatList);
            JsonFileBoatService.SaveJsonBoats(boats);
        }

        public Boat GetBoat(int id)
        {

            foreach (var boat in boats)
            {
                if (boat.Id == id)
                {
                    return boat;
                }
            }
            return null;
        }
        public List<Boat> listOfBoats()
        {
            return boats;
        }

        public Boat DeleteBoat(int id, Boat boat)

        {
            foreach (Boat b in boatList[id - 1].BoatList)
            {
                if (boat.Id == b.Id)
                {
                    boatList[id - 1].BoatList.Remove(b);
                    _jsonFileBoatListService.SaveJsonBoats(boatList);
                    DeleteBoat(b);
                    return b;
                }
            }
            return null;
        }

        public Boat DeleteBoat(Boat boat)
        {
            foreach(var b in boats)
            {
                if(boat.Id == b.Id)
                {
                    boats.Remove(b);
                    JsonFileBoatService.SaveJsonBoats(boats);
                    return b;
                }
            }
            return null;
        }

        public void EditBoat(Boat boat)
        {
            foreach (Boat b in boats)
            {
                if (b.Id == boat.Id)
                {
                    b.Booked = boat.Booked;
                }
            }
        }
        public void CreateBoatModel(Boat boat)
        {
            throw new NotImplementedException();
        }
        public void EditBoat(int id, Boat boat)
        {
            foreach (Boat b in boatList[id - 1].BoatList)
            {
                if (b.Id == boat.Id)
                {
                    b.Length = boat.Length;
                    b.Width = boat.Width;
                    b.Bom = boat.Bom;
                    b.Vægt = boat.Vægt;
                    b.Booked = b.Booked;
                    b.HasBom = boat.HasBom;

                    _jsonFileBoatListService.SaveJsonBoats(boatList);
                    JsonFileBoatService.SaveJsonBoats(boats);
                    break;
                }
            }
        }


        // Boats

        public Boats GetBoats(int id)
        {
            foreach (var b in boatList)
            {
                if (b.Id == id)
                {
                    return b;
                }
            }
            return null;
        }

        public List<Boat> GetBoatList(int id)
        {
            foreach (var b in boatList)
            {
                if (b.Id == id)
                {
                    return b.BoatList;
                }
            }
            return null;
        }


    }
}
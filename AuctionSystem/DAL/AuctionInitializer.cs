using AuctionSystem.DAL;
using AuctionSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace AuctionSystem.DAL
{
    public class AuctionInitializer : MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>
    {

        public static void SeedAuctionData(ApplicationDbContext context)
        {
            var categories = new List<Category>
            {
                new Category(){CategoryID=1, CategoryName="AGD", CategoryDesc="Znajdziesz tutaj wszystko co związane z AGD"},
                new Category(){CategoryID=2, CategoryName="RTV", CategoryDesc="Znajdziesz tutaj wszystko co związane z RTV"},
                new Category(){CategoryID=3, CategoryName="Biuro", CategoryDesc="Znajdziesz tutaj wszystko co związane z biurem"},
                new Category(){CategoryID=4, CategoryName="Meble", CategoryDesc="Znajdziesz tutaj wszystko co związane z meblami"},
                new Category(){CategoryID=5, CategoryName="Ogród", CategoryDesc="Znajdziesz tutaj wszystko co związane z ogrodem"},
            };

            categories.ForEach(category => context.Categories.AddOrUpdate(category));
            context.SaveChanges();


            var auctions = new List<Auction>
            {
                new Auction(){AuctionTitle="Pralka", AuctionDescription="opis pralki", AuctionPrice=1000, CategoryID=1, AuctionDateAdd = DateTime.Now, Hidden=false },
                new Auction(){AuctionTitle="Słuchawki", AuctionDescription="opis słuchawek", AuctionPrice=344, CategoryID=2, AuctionDateAdd = DateTime.Now, Hidden=false },
                new Auction(){AuctionTitle="Biurko", AuctionDescription="opis biurka", AuctionPrice=299, CategoryID=4, AuctionDateAdd = DateTime.Now, Hidden=false },
                new Auction(){AuctionTitle="Stolik ogrodowy", AuctionDescription="opis stolika ogrodowego", AuctionPrice=566, CategoryID=5, AuctionDateAdd = DateTime.Now, Hidden=false },
                new Auction(){AuctionTitle="Segregator", AuctionDescription="opis segragatora", AuctionPrice=788, CategoryID=3, AuctionDateAdd = DateTime.Now, Hidden=false },
            };

            auctions.ForEach(auction => context.Auctions.AddOrUpdate(auction));
            context.SaveChanges();

        }
    }
}
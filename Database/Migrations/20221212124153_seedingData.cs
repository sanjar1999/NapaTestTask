using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    public partial class seedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"insert into Product (ProductName, Quantity, Price) values ('Pear - Halves', 474, 86067);
insert into Product (ProductName, Quantity, Price) values ('Milk - Condensed', 676, 30787);
insert into Product (ProductName, Quantity, Price) values ('Oil - Sunflower', 50, 62558);
insert into Product (ProductName, Quantity, Price) values ('Yoplait - Strawbrasp Peac', 163, 33974);
insert into Product (ProductName, Quantity, Price) values ('Thyme - Dried', 21, 53001);
insert into Product (ProductName, Quantity, Price) values ('Sauce - Ranch Dressing', 701, 81204);
insert into Product (ProductName, Quantity, Price) values ('Cheese - Romano, Grated', 479, 74217);
insert into Product (ProductName, Quantity, Price) values ('Syrup - Monin, Irish Cream', 476, 12225);
insert into Product (ProductName, Quantity, Price) values ('Soup - Knorr, Country Bean', 561, 31142);
insert into Product (ProductName, Quantity, Price) values ('Cake - Lemon Chiffon', 440, 30755);
insert into Product (ProductName, Quantity, Price) values ('Filter - Coffee', 493, 57586);
insert into Product (ProductName, Quantity, Price) values ('The Pop Shoppe - Cream Soda', 263, 26552);
insert into Product (ProductName, Quantity, Price) values ('Rice - Brown', 667, 15592);
insert into Product (ProductName, Quantity, Price) values ('Bagelers', 117, 774);
insert into Product (ProductName, Quantity, Price) values ('Mushrooms - Black, Dried', 911, 14588);
insert into Product (ProductName, Quantity, Price) values ('Coffee - 10oz Cup 92961', 164, 3981);
insert into Product (ProductName, Quantity, Price) values ('Onions - Cooking', 144, 35501);
insert into Product (ProductName, Quantity, Price) values ('Cheese - Brie, Triple Creme', 994, 23102);
insert into Product (ProductName, Quantity, Price) values ('Potatoes - Mini White 3 Oz', 506, 56928);
insert into Product (ProductName, Quantity, Price) values ('Flower - Commercial Spider', 39, 60732);
insert into Product (ProductName, Quantity, Price) values ('Stock - Veal, Brown', 498, 51487);
insert into Product (ProductName, Quantity, Price) values ('Lettuce - Radicchio', 196, 76357);
insert into Product (ProductName, Quantity, Price) values ('Beans - Kidney, Red Dry', 819, 41830);
insert into Product (ProductName, Quantity, Price) values ('Cucumber - Pickling Ontario', 169, 63160);
insert into Product (ProductName, Quantity, Price) values ('Beer - True North Lager', 825, 32950);
insert into Product (ProductName, Quantity, Price) values ('Salami - Genova', 162, 34691);
insert into Product (ProductName, Quantity, Price) values ('Cookie Dough - Chocolate Chip', 508, 94252);
insert into Product (ProductName, Quantity, Price) values ('Ice Cream Bar - Oreo Sandwich', 442, 23428);
insert into Product (ProductName, Quantity, Price) values ('Island Oasis - Peach Daiquiri', 364, 85662);
insert into Product (ProductName, Quantity, Price) values ('Gatorade - Xfactor Berry', 180, 26642);
insert into Product (ProductName, Quantity, Price) values ('Pasta - Orecchiette', 697, 44642);
insert into Product (ProductName, Quantity, Price) values ('Nut - Pecan, Pieces', 721, 47018);
insert into Product (ProductName, Quantity, Price) values ('Anchovy In Oil', 593, 63221);
insert into Product (ProductName, Quantity, Price) values ('Cucumber - English', 455, 56298);
insert into Product (ProductName, Quantity, Price) values ('Bread - White Epi Baguette', 501, 2689);
insert into Product (ProductName, Quantity, Price) values ('Cranberries - Dry', 235, 58218);
insert into Product (ProductName, Quantity, Price) values ('Chocolate - Chips Compound', 784, 89092);
insert into Product (ProductName, Quantity, Price) values ('Cookies - Englishbay Chochip', 854, 48094);
insert into Product (ProductName, Quantity, Price) values ('Milk - Skim', 546, 73701);
insert into Product (ProductName, Quantity, Price) values ('Poppy Seed', 781, 52995);
insert into Product (ProductName, Quantity, Price) values ('Bread - Multigrain', 942, 86960);
insert into Product (ProductName, Quantity, Price) values ('Beef Flat Iron Steak', 150, 87811);
insert into Product (ProductName, Quantity, Price) values ('Lid - 0090 Clear', 953, 66417);
insert into Product (ProductName, Quantity, Price) values ('Cream - 35%', 727, 77262);
insert into Product (ProductName, Quantity, Price) values ('Papayas', 911, 65617);
insert into Product (ProductName, Quantity, Price) values ('Sandwich Wrap', 89, 94694);
insert into Product (ProductName, Quantity, Price) values ('Tart Shells - Savory, 4', 940, 42740);
insert into Product (ProductName, Quantity, Price) values ('Pie Box - Cello Window 2.5', 547, 7016);
insert into Product (ProductName, Quantity, Price) values ('Sauce - Plum', 396, 92623);
insert into Product (ProductName, Quantity, Price) values ('Sachet', 778, 27148);
insert into Product (ProductName, Quantity, Price) values ('Pastry - French Mini Assorted', 828, 2358);
insert into Product (ProductName, Quantity, Price) values ('Ham - Cooked Italian', 705, 42946);
insert into Product (ProductName, Quantity, Price) values ('Muffin Batt - Choc Chk', 124, 36577);
insert into Product (ProductName, Quantity, Price) values ('Potatoes - Parissienne', 593, 73196);
insert into Product (ProductName, Quantity, Price) values ('Sauce - Salsa', 235, 37491);
insert into Product (ProductName, Quantity, Price) values ('Vodka - Lemon, Absolut', 481, 57540);
insert into Product (ProductName, Quantity, Price) values ('Tray - Foam, Square 4 - S', 786, 79560);
insert into Product (ProductName, Quantity, Price) values ('Tray - Foam, Square 4 - S', 432, 84736);
insert into Product (ProductName, Quantity, Price) values ('Coffee Swiss Choc Almond', 172, 90058);
insert into Product (ProductName, Quantity, Price) values ('Cheese - Mozzarella, Shredded', 2, 14358);
insert into Product (ProductName, Quantity, Price) values ('Cardamon Seed / Pod', 297, 40655);
insert into Product (ProductName, Quantity, Price) values ('Oneshot Automatic Soap System', 258, 51767);
insert into Product (ProductName, Quantity, Price) values ('Cheese - Brick With Pepper', 974, 40978);
insert into Product (ProductName, Quantity, Price) values ('Pants Custom Dry Clean', 954, 35354);
insert into Product (ProductName, Quantity, Price) values ('Kippers - Smoked', 696, 58668);
insert into Product (ProductName, Quantity, Price) values ('Onions - Red', 6, 23683);
insert into Product (ProductName, Quantity, Price) values ('Cardamon Seed / Pod', 364, 95081);
insert into Product (ProductName, Quantity, Price) values ('Ecolab - Power Fusion', 256, 18852);
insert into Product (ProductName, Quantity, Price) values ('Crab - Claws, 26 - 30', 66, 12885);
insert into Product (ProductName, Quantity, Price) values ('Table Cloth 81x81 Colour', 521, 62130);
insert into Product (ProductName, Quantity, Price) values ('Cherries - Frozen', 562, 89881);
insert into Product (ProductName, Quantity, Price) values ('Dried Apple', 757, 2002);
insert into Product (ProductName, Quantity, Price) values ('Cheese - Cheddar, Old White', 932, 3283);
insert into Product (ProductName, Quantity, Price) values ('Cheese Cloth No 100', 118, 6628);
insert into Product (ProductName, Quantity, Price) values ('Spice - Chili Powder Mexican', 417, 20723);
insert into Product (ProductName, Quantity, Price) values ('Isomalt', 358, 79053);
insert into Product (ProductName, Quantity, Price) values ('Oil - Coconut', 508, 53723);
insert into Product (ProductName, Quantity, Price) values ('Wine - Jafflin Bourgongone', 881, 35034);
insert into Product (ProductName, Quantity, Price) values ('Apple - Northern Spy', 640, 1492);
insert into Product (ProductName, Quantity, Price) values ('Radish - Pickled', 558, 71190);
insert into Product (ProductName, Quantity, Price) values ('Lemonade - Pineapple Passion', 727, 17389);
insert into Product (ProductName, Quantity, Price) values ('Flower - Commercial Bronze', 617, 82452);
insert into Product (ProductName, Quantity, Price) values ('Coffee - Colombian, Portioned', 117, 78417);
insert into Product (ProductName, Quantity, Price) values ('Bagel - Whole White Sesame', 609, 24448);
insert into Product (ProductName, Quantity, Price) values ('Cake - French Pear Tart', 558, 41874);
insert into Product (ProductName, Quantity, Price) values ('Ice Cream Bar - Oreo Sandwich', 42, 55474);
insert into Product (ProductName, Quantity, Price) values ('Bread - Sour Batard', 663, 50963);
insert into Product (ProductName, Quantity, Price) values ('Salt And Pepper Mix - Black', 945, 31825);
insert into Product (ProductName, Quantity, Price) values ('Walkers Special Old Whiskey', 807, 15909);
insert into Product (ProductName, Quantity, Price) values ('Muffin Mix - Carrot', 993, 51492);
insert into Product (ProductName, Quantity, Price) values ('Crab - Dungeness, Whole, live', 870, 68758);
insert into Product (ProductName, Quantity, Price) values ('Beans - Fava, Canned', 894, 78696);
insert into Product (ProductName, Quantity, Price) values ('Vinegar - Sherry', 364, 49852);
insert into Product (ProductName, Quantity, Price) values ('Sugar - Monocystal / Rock', 974, 20675);
insert into Product (ProductName, Quantity, Price) values ('Wine - Peller Estates Late', 599, 80127);
insert into Product (ProductName, Quantity, Price) values ('Mushroom - White Button', 471, 15574);
insert into Product (ProductName, Quantity, Price) values ('Sugar - White Packet', 194, 19262);
insert into Product (ProductName, Quantity, Price) values ('Nantucket Orange Juice', 108, 41314);
insert into Product (ProductName, Quantity, Price) values ('Cheese - Brick With Pepper', 815, 28520);
insert into Product (ProductName, Quantity, Price) values ('Lamb - Whole, Frozen', 784, 33637);
");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

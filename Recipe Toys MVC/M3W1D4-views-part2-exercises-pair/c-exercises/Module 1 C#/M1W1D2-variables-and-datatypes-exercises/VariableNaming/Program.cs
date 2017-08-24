using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch? 
            */

            int branchBirds = 4;
            int birdsLeaving = 1;
            int finalBirds = branchBirds - birdsLeaving;

            /* 
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests? 
            */

            int birds = 6;
            int nests = 3;
            int birdNests = birds - nests;

            /* 
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods? 
            */
            int racconsWoods = 3;
            int racconsHome = 2;
            int racconsLeft = racconsWoods - racconsHome;

            /* 
            4. There are 5 flowers and 3 bees. How many less bees than flowers? 
            */
            int flowers = 5;
            int bees = 3;
            int lessBees = flowers - bees;
            /* 
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now? 
            */
            int lonelyPigeon = 1;
            int bravePigeon = 1;
            int totalPigeons = lonelyPigeon + bravePigeon;
            /* 
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now? 
            */
            int fenceOwls = 3;
            int newOwls = 2;
            int totalOwls = fenceOwls + newOwls;
            /* 
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home? 
            */
            int homeBeavers = 2;
            int swimBeavers = 1;
            int workingBeavers = homeBeavers - swimBeavers;
            /* 
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all? 
            */
            int treeToucans = 2;
            int joinToucan = 1;
            int totalToucans = treeToucans + joinToucan;
            /* 
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts? 
            */
            int squirrels = 4;
            int nuts = 2;
            int squirrelNuts = squirrels / nuts;
            /* 
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find? 
            */
            int quarter = 25;
            int dime = 10;
            int nickel = 5;
            int totalFind = quarter + dime + nickel;
            /* 
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all? 
            */
            int classOne = 18;
            int classTwo = 20;
            int classThree = 17;
            int totalMuffins = classOne + classTwo + classThree;
            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */
            double yoyo = 0.24;
            double whistle = 0.14;
            double moneySpent = yoyo + whistle;
            /*
            13. Mrs. Hilt made 5 Rice Krispie Treats. She used 8 large marshmallows
            and 10 mini marshmallows.How many marshmallows did she use
            altogether?
            */
            int largeMarshmellows = 8;
            int miniMarshmellows = 10;
            int totalMarshmellows = largeMarshmellows + miniMarshmellows;
            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */
            int hiltHouse = 29;
            int schoolSnow = 17;
            int moreSnow = hiltHouse - schoolSnow;
            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */
            int totalDollars = 10;
            int toyTruck = 3;
            int pencilCase = 2;
            int finalDollars = totalDollars - (toyTruck + pencilCase);
            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */
            int totalMarbles = 16;
            int lostMarbles = 7;
            int leftMarbles = totalMarbles - lostMarbles;
            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */
            int meganShells = 19;
            int wantedShells = 25;
            int neededShells = wantedShells - meganShells;
            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */
            int bradBalloons = 17;
            int redBalloons = 8;
            int greenBalloons = bradBalloons - redBalloons;
            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */
            int shelfBooks = 38;
            int martaBooks = 10;
            int totalBooks = shelfBooks + martaBooks;
            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */
            int beeLegs = 6;
            int totalBees = 8;
            int totalLegs = beeLegs * totalBees;
            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */
            double iceCreamCone = 0.99;
            int totalCones = 2;
            double coneCost = totalCones * iceCreamCone;

            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */
            int currentRocks = 64;
            int neededRocks = 125;
            int remainingRocks = neededRocks - currentRocks;

            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */
            int hiltMarbles = 38;
            int hiltLost = 15;
            int hiltMarblesLeft = hiltMarbles - hiltLost;
            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */
            int concertMiles = 78;
            int drivenMiles = 32;
            int leftMiles = concertMiles - drivenMiles;
            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time did she spend shoveling snow?
            */
            int saturdaySnow = 90;
            int saturdayAfternoon = 45;
            int totalTime = saturdaySnow + saturdayAfternoon;
            /*    
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */
            int totalHotDogs = 6;
            double costHotDog = 0.50;
            double totalCost = totalHotDogs * costHotDog;
            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */
            double totalMoney = 0.50;
            double pencilCost = 0.07;
            double totalPencils = totalMoney / pencilCost;
            /*    
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */
            int seeButterflies = 33;
            int orangeButterflies = 20;
            int redButterflies = seeButterflies - orangeButterflies;
            /*    
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */
            double clerkMoney = 1.00;
            double candyMoney = 0.54;
            double kateChange = clerkMoney - candyMoney;
            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */
            int firstTrees = 13;
            int plantTrees = 12;
            int totalTrees = firstTrees + plantTrees;
            /*    
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */
            int oneDay = 24;
            int totalHours = oneDay * 2;
            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */
            int totalCousins = 4;
            int kimGum = 5;
            int totalGum = totalCousins * kimGum;
            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */
            double danMoney = 3.00;
            double danCandy = 1.00;
            double danMoneyLeft = danMoney - danCandy;
            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */
            int numBoats = 5;
            int numPeople = 3;
            int peopleTotal = numBoats * numPeople;
            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */
            int startingLegos = 380;
            int legosLost = 57;
            int finalLegos = startingLegos - legosLost;
            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */
            int bakedMuffins = 35;
            int neededMuffins = 83;
            int toBakeMuffins = neededMuffins - bakedMuffins;
            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */
            int willyCrayons = 1400;
            int lucyCrayons = 290;
            int moreCrayons = willyCrayons - lucyCrayons;
            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */
            int pageStickers = 10;
            int numPages = 22;
            int numStickers = pageStickers * numPages;
            /*
            39. There are 96 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */
            int cupcakeTotal = 96;
            int childrenTotal = 8;
            int shareCupcakes = cupcakeTotal / childrenTotal;
            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies each, how many
            cookies will not be placed in a jar?
            */
            int gingerCookies = 47;
            int cookiePerJar = 6;
            int cookieNotJar = gingerCookies % cookiePerJar;
            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received and equal number of croissants,
            how many will be left with Marian?
            */
            int numCroissants = 59;
            int numNeighbors = 8;
            int marianLeft = numCroissants % numNeighbors;
            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */
            int oatmealCookies = 276;
            int cookieOnTray = 12;
            int numOfTrays = oatmealCookies / cookieOnTray;
            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */
            int bitePretzels = 480;
            int biteServing = 12;
            float numServings = bitePretzels / biteServing;
            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */
            int lemonCupcakes = 53;
            int lemonHome = 2;
            int lemonBoxes = 3;
            int boxTotal = (lemonCupcakes - lemonHome) / lemonBoxes;
            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */
            int carrotSticks = 74;
            int carrotPeople = 12;
            int carrotsLeft = carrotSticks % carrotPeople;
            Console.WriteLine(carrotsLeft);
            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */
            int teddyBears = 98;
            int shelfCarry = 7;
            int shelfFilled = teddyBears / shelfCarry;
            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */
            int familyPictures = 480;
            int albumPictures = 20;
            int albumTotal = familyPictures / albumPictures;
            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */
            int tradingCards = 94;
            int fullBox = 8;
            int boxunFilled = tradingCards % fullBox;
            int boxFilled = tradingCards / fullBox;
            Console.WriteLine(boxunFilled);
            Console.WriteLine(boxunFilled);
            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */
            int readingBooks = 210;
            int repairedShelves = 10;
            int containedShelves = readingBooks / repairedShelves;
            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */
            int cristCroissants = 17;
            int numGuests = 7;
            float equalPortion = cristCroissants / numGuests;
            Console.WriteLine(equalPortion);
            Console.Read();
        }
    }
}

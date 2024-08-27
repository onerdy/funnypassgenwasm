using funnypassgenwasm.Models;
using System;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace funnypassgenwasm.Services
{
    public class GeneratorService
    {
        static Random random = new Random();

        public static string GeneratePassword(PasswordOptions passwordOptions)
        {
            string password = "";
            
            string[] allFunnyWords = [
            "airhead",
            "arsegoblin",
            "assclown",
            "ballsack",
            "bamboozle",
            "bastard",
            "bedswerver",
            "bimbo",
            "bitchslap",
            "biteme",
            "boink",
            "bootycall",
            "bouffant",
            "bozo",
            "bugger",
            "bulbous",
            "bullcrap",
            "bumblefuck",
            "bumfuzzle",
            "buttface",
            "cameltoe",
            "cattywampus",
            "chucklefuck",
            "churlish",
            "cornhole",
            "crabshack",
            "dickweed",
            "dildo",
            "dingleberry",
            "dirty",
            "dogfart",
            "dongle",
            "douchenozzle",
            "eggplant",
            "erectile",
            "erogenous",
            "flatulence",
            "fondle",
            "fubar",
            "fucktrumpet",
            "fugly",
            "genital",
            "gonads",
            "lollygag",
            "lube",
            "herpes",
            "hillbilly",
            "horny",
            "jackass",
            "kerfuffle",
            "knockers",
            "knucklehead",
            "malarkey",
            "milf",
            "moist",
            "munter",
            "nasty",
            "nincompoop",
            "ninnymuggins",
            "nipple",
            "peckerwood",
            "peehole",
            "penile",
            "pitiful",
            "poontang",
            "porno",
            "quickie",
            "redneck",
            "repugnant",
            "sausage",
            "scabby",
            "schmuck",
            "scrotum",
            "scummy",
            "shaggin",
            "shenanigans",
            "shithead",
            "smorgasboard",
            "snockered",
            "snollygoster",
            "stanky",
            "stripclub",
            "taint",
            "testicle",
            "titdirt",
            "tatertits",
            "twerp",
            "vibrator",
            "wanker",
            "yellowbelly",
            "yomama"
            ];

            string[] seedWords = [];

            seedWords = ShuffleAndExtract(allFunnyWords);

            if (passwordOptions.Capitalize)
            {
                seedWords = Capitalize(seedWords);
            }

            password = String.Join(passwordOptions.SeparatorChar, seedWords);

            if (passwordOptions.AddNumber)
            {
                password += random.Next(10);
            }

            return password;


            string[] ShuffleAndExtract(string[] arrayToShuffleAndExtract)
            {
                return arrayToShuffleAndExtract.OrderBy(_ => random.Next())
                            .Take(passwordOptions.NumberOfWords).ToArray();
            }

            string[] Capitalize(string[] arrayToCapitalize)
            {
                return arrayToCapitalize.Select(word => word[0].ToString().ToUpper() + word.Substring(1)).ToArray();
            }
        }

    }
}
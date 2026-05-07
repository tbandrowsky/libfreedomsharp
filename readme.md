# Freedom Finder

## About
Freedom Finder is a tool that lets people around the globe make a few extra dollars sticking it to those counties in the USA whose 
people are most attempting to oppress their own people and attack the world.  If you've got a small shop in Canada, Europe, India, the Phillipineses, China, the Middle East, 
anywhere, you can use Freedom Finder to determine if an American is generally of the sort that is trying to blow your country up, take over, or otherwise get crapped on in a tweet 
storm by the President and his minions.  Over time, as more vendors and providers of goods and resources around the world, even in the USA, use Freedom Finder or develop 
similar capabilities, we can determine the effects and practicality of applying a meaningful consumer driven impedence.  Over time that has been proven to be corrective.  

## Using
Freedom Finder is a C# library.  Once you have a reference to it, just call it.  Then, if it is true, you can alter your business decision.

            FreedomFinder ff = new FreedomFinder();

            var tax = ff.GetTax("42101");
            Assert.IsTrue(tax);

            tax = ff.GetTax("10014");
            tax = !tax;
            Assert.IsTrue(tax);

## Marketing and Design Considerations

Most US financial institutions and businesses are heavily regulated and monitored, which can impact the adoption and implementation of tools like Freedom Finder.  However, they are all generally 
located outside the United States for IT operations, where such scrutiny is less intense. 

C# here is used because everyone knows it.  C# runs on everything.   And I wanted a library that was as small as possible, not reliant on anything, so this Freedom Finder can stand alone

and embed that decision into any appliance.  If C# can't help you, go to the repo and grab the code and port it to C++ or Rust.  

Then you can run it on phones too and provide alerts for driving through or avoiding tyrant counties, or asking for delivery surcharges.  The guys living there threatened to invade Canada, Greenland, Nuke Iran, 

all while watching Russia walk all over Europe.  So, like, they can use some correction, and we can all use extra money.


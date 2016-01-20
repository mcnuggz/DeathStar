using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading;
using TopSecretPlans;
using System.Media;
using System.Net.Mail;

namespace DeathStar
{
    public class DeathStar
    {
        #region member variables
        Mainexhaustport mainExhaustPort;
        Thermalexhaustport ThermalExhaustPort;
        TractorBeam tractorBeam;
        TractorBeamGenerator tractorBeamGenerator;
        EmergencyRadiationDischarge emergencyRadiationDischarge;
        MainPowerGenerator mainPowerGenerator;
        HyperMatterReactor hyperMatterReactor;
        IonDriveReactor ionDriveReactor;
        OverBridge overBridge;
        SuperLaser superLaser;
        MagneticShielding magneticShielding;
        HyperDrive hyperDrive;
        PowerCell powerCell;
        CentralComputerCore centralComputerCore;
        HeatExchanger heatExchanger;
        CoolingSystem coolingSystem;
        Refinery refinery;
        FuelCollector fuelCollector;
        ExteriorQuadaniumsteelouterhull exteriorQuadaniumSteelOuterHull;
        SecondaryPowerConverters secondaryPowerConverters;
        CentralPowerColumn centralPowerColumn;
        TractorBeamReactorCoupling tractorBeamReactorCoupling;
        TractorBeamGeneratorTower tractorBeamGeneratorTower;
        ConcentricSurfaceDecks concentricSurfaceDecks;
        IonSublightEngines ionSublightEngines;
        AtmosphereProcessingUnit atmosphereProcessingUnit;
        WaterTanks waterTanks;
        SuperLaserPowerCell superlaserPowerCell;
        PrimaryPowerAmplifier primaryPowerAmplifier;
        FiringFieldAmplifier firingFieldAmplifier;
        InductionHyperphaseGenerator inductionHyperphaseGenerator;
        TargetingFieldGenerator targetingFieldGenerator;
        PrimaryBeamFocusingMagnet primaryBeamFocusingMagnet;
        CarrierBeamCrystal carrierBeamCrystal;
        SuperlaserTributaryBeamShaft superlaserTributaryBeamShaft;
        SectorComputerCluster sectorComputerCluster;
        StellarFuelBottles stellarFuelBottles;
        Armory armory;

        #endregion
        private string musicFile = "AwfulNoise.wav";
        public void FloatOminously()
        {
            Console.WriteLine("Floatin' around in SPAAAAAAAAAAAACE");
            Thread.Sleep(2000);
        }

        public void DeployTroops()
        {
            armory.TakeWeapons();
            armory.TakeAmmo();
        }

        public void PlayTheMusic()
        {
            SoundPlayer player = new SoundPlayer(musicFile);
            Console.WriteLine("Playing");
            player.Play();
        }
        public void SendEmail(string emailAddress)
        {
            try
            {
                MailMessage mail = new MailMessage();
                var client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("dzanfox@gmail.com", "theveldt13"),
                    EnableSsl = true
                };
                mail.From = new MailAddress("dzanfox@gmail.com");
                mail.To.Add(emailAddress);
                mail.Subject = "Greetings from the DeathStar";
                mail.Body = "SPAAAAAAAACE";

                Attachment attachment;
                attachment = new Attachment(@"space.jpg");
                mail.Attachments.Add(attachment);

                client.Send(mail);
                Console.WriteLine("Sent");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}

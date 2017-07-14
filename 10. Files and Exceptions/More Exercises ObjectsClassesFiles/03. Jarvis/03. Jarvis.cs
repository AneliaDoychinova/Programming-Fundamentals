using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Jarvis
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxEnergyCapacity = long.Parse(Console.ReadLine());
            Jarvis jarvis = new Jarvis();
            jarvis.Energy = maxEnergyCapacity;

            var input = Console.ReadLine();

            while (input != "Assemble!")
            {
                var tokens = input.Split(' ');

                switch (tokens[0])
                {
                    case "Head":
                        Head head = new Head 
                        {
                            EnergyConsumption = int.Parse(tokens[1]),
                            Iq = int.Parse(tokens[2]),
                            SkinMaterial = tokens[3]
                            
                        };
                        jarvis.AddHead(head);
                        break;
                    case "Torso":
                        Torso torso = new Torso
                        {
                            EnergyConsumption = int.Parse(tokens[1]),
                            ProcessorSize = int.Parse(tokens[2]),
                            HousingMaterial = tokens[3]

                        };
                        jarvis.AddTorso(torso);
                        break;
                    case "Arm":
                        Arms arm = new Arms
                        {
                            EnergyConsumption = int.Parse(tokens[1]),
                            ArmReachDistance = int.Parse(tokens[2]),
                            CountOfFingers = int.Parse(tokens[3])

                        };
                        jarvis.AddArms(arm);
                        break;
                    case "Leg":
                        Legs leg = new Legs
                        {
                            EnergyConsumption = int.Parse(tokens[1]),
                            Strenght = int.Parse(tokens[2]),
                            Speed = int.Parse(tokens[3])

                        };
                        jarvis.AddLegs(leg);
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(jarvis.ToString());
        }
        class Jarvis
        {
            public long Energy { get; set; }

            public Torso Torso { get; set; }

            public Head Head { get; set; }

            public List<Legs> Legs { get; set; }

            public List<Arms> Arms { get; set; }

            public void AddHead(Head headInput)
            {
                if (Head == null)
                {
                    Head = headInput;
                }
                if (headInput.EnergyConsumption < Head.EnergyConsumption)
                {
                    Head = headInput;
                }
            }

            public void AddTorso(Torso torsoInput)
            {
                if (Torso == null)
                {
                    Torso = torsoInput;
                }
                if (torsoInput.EnergyConsumption < Torso.EnergyConsumption)
                {
                    Torso = torsoInput;
                }
            }

            public void AddArms(Arms armsInput)
            {
                if (Arms == null)
                {
                    Arms = new List<Arms>();
                }
                if (Arms.Count < 2)
                {
                    Arms.Add(armsInput);
                }
                else
                {
                    for (int i = 0; i < this.Arms.Count; i++)
                    {
                        if (Arms[i].EnergyConsumption > armsInput.EnergyConsumption)
                        {
                            Arms.RemoveAt(i);
                            Arms.Add(armsInput);
                        }
                    }
                }
            }

            public void AddLegs(Legs legsInput)
            {
                if (Legs == null)
                {
                    Legs = new List<Legs>();
                }
                if (Legs.Count < 2)
                {
                    Legs.Add(legsInput);
                }
                else
                {
                    for (int i = 0; i < this.Legs.Count; i++)
                    {
                        if (Legs[i].EnergyConsumption > legsInput.EnergyConsumption)
                        {
                            Legs.RemoveAt(i);
                            Legs.Add(legsInput);
                        }
                    }
                }
            }

            public override string ToString()
            {
                if (Head == null || Torso == null || Legs.Count < 2 || Arms.Count < 2)
                {
                    return "We need more parts!";
                }

                long totalEnergy = 0;
                totalEnergy += Torso.EnergyConsumption;
                totalEnergy += Head.EnergyConsumption;
                totalEnergy += Arms.Select(x => x.EnergyConsumption).Sum();
                totalEnergy += Legs.Select(x => x.EnergyConsumption).Sum();

                if (totalEnergy > Energy)
                {
                    return "We need more power!";
                }

                StringBuilder sb = new StringBuilder();

                sb.Append("Jarvis:" + Environment.NewLine);
                sb.Append(Head.ToString());
                sb.Append(Torso.ToString());
                foreach (var arm in Arms.OrderBy(x => x.EnergyConsumption))
                {
                    sb.Append(arm.ToString());
                }
                foreach (var leg in Legs.OrderBy(x => x.EnergyConsumption))
                {
                    sb.Append(leg.ToString());
                }
                return sb.ToString();
            }

        }
        class Arms
        {
            public long EnergyConsumption { get; set; }

            public int ArmReachDistance { get; set; }

            public int CountOfFingers { get; set; }

            public override string ToString()
            {
                string result = string.Empty;
                result += "#Arm:" + Environment.NewLine;
                result += "###Energy consumption: " + EnergyConsumption + Environment.NewLine;
                result += "###Reach: " + ArmReachDistance + Environment.NewLine;
                result += "###Fingers: " + CountOfFingers + Environment.NewLine;

                return result;
            }
        }

        class Legs
        {
            public long EnergyConsumption { get; set; }

            public int Strenght { get; set; }

            public int Speed { get; set; }

            public override string ToString()
            {
                string result = string.Empty;
                result += "#Leg:" + Environment.NewLine;
                result += "###Energy consumption: " + EnergyConsumption + Environment.NewLine;
                result += "###Strength: " + Strenght + Environment.NewLine;
                result += "###Speed: " + Speed + Environment.NewLine;

                return result;
            }
        }

        class Torso
        {
            public int EnergyConsumption { get; set; }

            public double ProcessorSize { get; set; }

            public string HousingMaterial { get; set; }

            public override string ToString()
            {
                string result = string.Empty;
                result += "#Torso:" + Environment.NewLine;
                result += "###Energy consumption: " + EnergyConsumption + Environment.NewLine;
                result += "###Processor size: " + ProcessorSize + Environment.NewLine;
                result += "###Corpus material: " + HousingMaterial + Environment.NewLine;

                return result;
            }
        }

        class Head
        {
            public int EnergyConsumption { get; set; }

            public int Iq { get; set; }

            public string SkinMaterial { get; set; }

            public override string ToString()
            {
                string result = string.Empty;
                result += "#Head:" + Environment.NewLine;
                result += "###Energy consumption: " + EnergyConsumption + Environment.NewLine;
                result += "###IQ: " + Iq + Environment.NewLine;
                result += "###Skin material: " + SkinMaterial + Environment.NewLine;

                return result;
            }
        }
    }
}

﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fruit_Ninja
{
    public class Element
    {
        public Image image;
        public Point ulCorner;
        public Point urCorner;
        public Point llCorner;
        public int directionX;
        public int directionY;
        public static Random r = new Random();
        public bool enabled;
        public string type;

        public Element()
        {
            generate();
            enabled = true;
        }

        public void Draw(PaintEventArgs e)
        {
            Image newImage = image;
            Point[] destPara = { ulCorner, urCorner, llCorner };
            e.Graphics.DrawImage(newImage, destPara);
        }

        public void Move()
        {
            if (enabled)
            {
                if (ulCorner.Y <= 0 || urCorner.Y <= 0)
                {
                    directionY = 10;
                    directionX = 0;
                    enabled = false;
                }
                else if (ulCorner.X <= 0 || urCorner.X >= SettingsForm.settings.width)
                {
                    directionY = -10;
                    directionX = -directionX;
                }
            }
            ulCorner = new Point(ulCorner.X + directionX, ulCorner.Y + directionY);
            urCorner = new Point(urCorner.X + directionX, urCorner.Y + directionY);
            llCorner = new Point(llCorner.X + directionX, llCorner.Y + directionY);
        }
         
        public bool isClicked(Point p)
        {
            if (p.X >= ulCorner.X && p.X <= urCorner.X && p.Y >= ulCorner.Y && p.Y <= llCorner.Y)
                return true;
            return false;
        }

        public void generate()
        {
            string difficulty = SettingsForm.settings.difficulty;
            int availableElements = 0;
            if (difficulty.ToUpper().Equals("EASY"))
                availableElements = 9;
            else if (difficulty.ToUpper().Equals("MEDIUM"))
                availableElements = 9;
            else if (difficulty.ToUpper().Equals("HARD"))
                availableElements = 10;
            int chosen = r.Next(availableElements);
            switch (chosen)
            {
                case 0:
                    {
                        image = Properties.Resources.Banana;
                        type = "Fruit";
                        break;
                    }
                case 1:
                    {
                        image = Properties.Resources.Green_Apple;
                        type = "Fruit";
                        break;
                    }
                case 2:
                    {
                        image = Properties.Resources.Watermelon;
                        type = "Fruit";
                        break;
                    }
                case 3:
                    {
                        image = Properties.Resources.cabbage;
                        type = "Vegetable";
                        break;
                    }
                case 4:
                    {
                        image = Properties.Resources.carrot;
                        type = "Vegetable";
                        break;
                    }
                case 5:
                    {
                        image = Properties.Resources.eggplant;
                        type = "Vegetable";
                        break;
                    }
                case 6:
                    {
                        image = Properties.Resources.cake;
                        type = "Dessert";
                        break;
                    }
                case 7:
                    {
                        image = Properties.Resources.icecream;
                        type = "Dessert";
                        break;
                    }
                case 8:
                    {
                        image = Properties.Resources.chocolate;
                        type = "Dessert";
                        break;
                    }
                case 9:
                    {
                        image = Properties.Resources.bombGameOver;
                        type = "GameOverBomb";
                        break;
                    }
                default:
                    {
                        type = "";
                        break;
                    }
            }
            int positions = (SettingsForm.settings.width - 20) / image.Width;
            int currentPosition = r.Next(positions);
            ulCorner = new Point(currentPosition * image.Width + 10, SettingsForm.settings.height - image.Height / 2);
            urCorner = new Point((currentPosition + 1) * image.Width, SettingsForm.settings.height - image.Height / 2);
            llCorner = new Point(currentPosition * image.Width + 10, SettingsForm.settings.height + image.Height / 2);
            directionX = 0;
            directionY = -10;
            if (currentPosition == 0)
            {
                directionX = 10;
            }
            else if (currentPosition < positions / 2)
            {
                int d = r.Next(2);
                if (d == 0)
                    directionX = 10;
                else
                    directionX = -10;
            }
            else if (currentPosition == positions - 1)
            {
                directionX = -10;
            }
            else
            {
                int d = r.Next(2);
                if (d == 0)
                    directionX = 10;
                else
                    directionX = -10;
            }
        }
    }
}

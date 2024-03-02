using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BradesAppTest
{
    public static class Gestos
    {
        public static void SwipeTopRight(AppiumDriver<AndroidElement> driver)
        {
            var finger = new PointerInputDevice(PointerKind.Touch);
            var start = new Point(829, 474);
            var end = new Point(74, 470);
            var swipe = new ActionSequence(finger);
            swipe.AddAction(finger.CreatePointerMove(CoordinateOrigin.Viewport, start.X, start.Y, TimeSpan.Zero));
            swipe.AddAction(finger.CreatePointerDown(MouseButton.Left));
            swipe.AddAction(finger.CreatePointerMove(CoordinateOrigin.Viewport, end.X, end.Y, TimeSpan.FromMilliseconds(1000)));
            swipe.AddAction(finger.CreatePointerUp(MouseButton.Left));
            driver.PerformActions(new List<ActionSequence> { swipe });
        }

        public static void SwipeTopLeft(AppiumDriver<AndroidElement> driver)
        {
            var finger = new PointerInputDevice(PointerKind.Touch);
            var start = new Point(175, 447);
            var end = new Point(898, 451);
            var swipe = new ActionSequence(finger);
            swipe.AddAction(finger.CreatePointerMove(CoordinateOrigin.Viewport, start.X, start.Y, TimeSpan.Zero));
            swipe.AddAction(finger.CreatePointerDown(MouseButton.Left));
            swipe.AddAction(finger.CreatePointerMove(CoordinateOrigin.Viewport, end.X, end.Y, TimeSpan.FromMilliseconds(1000)));
            swipe.AddAction(finger.CreatePointerUp(MouseButton.Left));
            driver.PerformActions(new List<ActionSequence> { swipe });
        }

        public static void TapBurguerRight(AppiumDriver<AndroidElement> driver)
        {
            var finger = new PointerInputDevice(PointerKind.Touch);
            var tapPoint = new Point(1026, 235);
            var tap = new ActionSequence(finger);
            tap.AddAction(finger.CreatePointerMove(CoordinateOrigin.Viewport, tapPoint.X, tapPoint.Y, TimeSpan.Zero));
            tap.AddAction(finger.CreatePointerDown(MouseButton.Left));
            tap.AddAction(finger.CreatePointerUp(MouseButton.Left));
            driver.PerformActions(new List<ActionSequence> { tap });
        }
    }
}

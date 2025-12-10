# EyeTrackingDemo

## Overview

This Unity project demonstrates how to use the Xrpa eye tracking module to
integrate the Pupil Labs' Neon eye tracking hardware into a Unity project. The
same module can also be used to integrate with Python or C++ applications.

## Setup the Neon hardware

This is just the basic instructions for setting up the Neon hardware, please see
their documentation for more details.

- Set up the phone with basically everything turned off download apps,
  unfortunately. You can create a new throwaway account for this.
- Install the Neon Companion app from the Google Play Store. It will ask you to
  add a payment method but you can skip that screen.
- Open the app and login with your google account.
- Turn off Cloud Upload in the app.
- Follow the instructions to connect the Neon device.

Verify it is operational:

- Click on the camera icon in the lower right to make sure the device is
  working.
- In your computer browser, go to http://neon.local:8080 to see the video with
  overlayed eye gaze

## Installing dependencies

`yarn`

Download the
[xred-eye-tracking module](https://github.com/facebookexperimental/xrpa/releases/download/v1.15.0/xred-eye-tracking.zip)
and unzip it into the `bin` folder. This zip file contains the executables for
the eye tracking module (for Windows and Mac).

On MacOS you may need to run `chmod +x bin/PupilNeon` to give the executable
permission to run.

## Unity Setup

Select the EyeTracker object in the sample scene. In the Inspector, set the IP
address to the IP address of the Neon device (you can find this in the companion
app).

## Running the eye tracking module

Windows: `yarn EyeTracking`

Mac: `yarn EyeTracking-mac`

Keep this running in a separate terminal window while you run the Unity project.

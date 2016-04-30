///////////////////////////////////////////////////////
VERSION 4.0:
at January 17, 2015


///////////////////////////////////////////////////////
4.0
+ Easier to use with static methods
+ Add Toast feature
+ Support event listeners of interstitial ad
+ Latest Google Play Services library version : 6587000

3.0
+ Change code logic, no more delay.
+ Latest Google Play Services library version : 5089000

2.2
+ Bugs fixed

2.1
+ Remove unnecessary permission

2.0
+ Simplest Admob Interagtion
+ Lastest Google Play Services
+ No more banner toast

1.1
+ show and hide bannersupport

1.0
+ first version


///////////////////////////////////////////////////////
WHAT'S NEW of 4.0:
- Toast.showText("This is toast message", Toast.LENGTH_LONG), now you can toast without other plugins
- New static method help you call ad methods from everywhere:
	+ AdmobVNTIS._showBanner ();
	+ AdmobVNTIS._hideBanner ();
	+ AdmobVNTIS._get ();  //get AdmovVNTIS for advance task;
	+ AdmobVNTIS_Interstitial._showInterstitial ();
	+ AdmobVNTIS_Interstitial._showInterstitialImmediately ();
	+ AdmobVNTIS_Interstitial._numberOfImpressions ();
	+ AdmobVNTIS_Interstitial._isAdLoaded ();
	+ AdmobVNTIS_Interstitial._get (); //get AdmovVNTIS_Interstitial for advance task;
- Now you can listen to ad event and call your method.

WHAT'S NEW of 3.0:
- ShowInterstitialImmediately(): if interstitial isnt ready when you call this medthod, it will try to get the interstitial ready but WON'T show the interstitial after that
< ShowInterstitial() (origin method): if interstitial isnt ready when you call this medthod, it will try to get the interstitial ready and show the interstitial after that >

- Now, there are 3 more options in Interstitial Script
	+ Retry Time Out (sec): if interstitial fail to load* (cause be network, server, ad,..etc), waiting "Retry Time Out" and retry
	+ Extend Time Out Percent (percent): increase the above variable by percent each retrying time
	+ Time Out Max (sec): if the retry time out increase and reach this maximum, stop retrying

(load* : mean load the ad into memory, so, it will show the ad after loaded or not depend on you call ShowInterstitial() or ShowInterstitialImmediately() )

///////////////////////////////////////////////////////
FEATURES:
- the easiest to use
- support banner types
- support interstitial
- support align adview
- support a test device
- support show and hide banner

Note: This Admob Plug-in was made from Unity4.3 and Android SDK


///////////////////////////////////////////////////////
HOW TO BASIC USE:

NOTE: the Publisher ID of "the old Admob" is Ad unit ID of "the new Admob"

Banner types:

1. Import the Admob_VNTIS.unitypackage

2. Drag and drop the AdmobVNTISObject prefab (locate at Assets\AdmobVNTIS\) to your scene

3. In the Inspector of AdmobVNTISObject, fill your Admob Publisher ID

4. Fill your test device ID (just 1) for test, otherwise leave blank

5. Choose your Advertisement Size (type)

6. Add rules to align Adview
6.1 Expand the Advertisement Rules
6.2 Set Size : the numbers of alignment rules you need
6.3 Set rule on each Elements

7. Check Show On Load

8. Build & run on device => Done

////////////////////
Interstitial:

1. Import the Admob_VNTIS.unitypackage

2. Drag and drop the AdmobVNTISInterstitialObject prefab (locate at Assets\AdmobVNTIS\) to your scene

3. In the Inspector of AdmobVNTISInterstitialObject, fill your Admob Publisher ID

4. Fill your test device ID (just 1) for test, otherwise leave blank

5. Check Show Interstitial On Load

6. Build & run on device => Done

////////////////////
Advance features (include manually show/hide banner)for Banner: see AdmobVNTIS\Demo\BannerDemo.unity scene
Manually show Interstitial: see AdmobVNTIS\Demo\InterstitialDemo.unity scene

///////////////////////////////////////////
Official support link : http://forum.unity3d.com/threads/236156-Admob-Unity-Plug-in-use-Google-Play-Services-support-Interstitial
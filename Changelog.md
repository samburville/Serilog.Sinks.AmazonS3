Change history
--------------

* **Version 1.2.0.0 (2021-09-12)** : Added example of loading logger config from appsettings (Thanks to @stylesm), added validation for the serviceUrl property (Thanks to @stylesm), updated icon, smaller adjustements due to move to the serilog-contrib organization, updated NuGet packages.
* **Version 1.1.11.0 (2021-09-03)** : Updated license to fit the new owning repository, updated readme and so on to fit new package name.
* **Version 1.1.10.0 (2021-08-29)** : Removed logging of S3 responses (Thanks to @KindOfANiceGuy), updated nuget packages.
* **Version 1.1.9.0 (2021-08-09)** : Removed support for soon deprecated NetCore 2.1.
* **Version 1.1.8.0 (2021-07-25)** : Updated nuget packages, enabled source linking for debugging.
* **Version 1.1.7.0 (2021-06-04)** : Updated nuget packages.
* **Version 1.1.6.0 (2021-05-15)** : Updated nuget packages.
* **Version 1.1.5.0 (2021-04-29)** : Updated nuget packages.
* **Version 1.1.4.0 (2021-03-31)** : Updated nuget packages, fixed a bug where the Service url wasn't injected correctly (Thanks to [aherrmann13](https://github.com/aherrmann13)).
* **Version 1.1.3.0 (2021-03-31)** : Updated nuget packages, fixed a bug where the Amazon S3 client wasn't injected correctly (Thanks to [longfin](https://github.com/longfin)).
* **Version 1.1.2.0 (2021-02-27)** : Updated nuget packages, added deletion of local files.
* **Version 1.1.1.0 (2021-02-21)** : Fixed a null reference exception with the formatter property.
* **Version 1.1.0.0 (2021-02-03)** : Big rework of the sink to make it work better. Check the options to configure the new sink.
* **Version 1.0.12.0 (2020-07-16)** : Added default AWS S3 serviceUrl.
* **Version 1.0.11.0 (2020-07-15)** : Updated nuget packages, added new constructor taking serviceUrl instead of endpoint (Thanks to [Galouw](https://github.com/Galouw)).
* **Version 1.0.10.0 (2020-06-05)** : Updated nuget packages, adjusted build to Visual Studio, moved changelog to extra file.
* **Version 1.0.9.0 (2020-05-10)** : Updated nuget packages, added option to add standard and custom formatters.
* **Version 1.0.8.0 (2020-03-26)** : Updated nuget packages.
* **Version 1.0.7.0 (2020-02-09)** : Updated nuget packages, updated available versions.
* **Version 1.0.6.0 (2019-12-09)** : Fixed nuget package dependency bug.
* **Version 1.0.5.0 (2019-12-08)** : Updated nuget packages, added new option "bucketPath" to the sink.
* **Version 1.0.4.0 (2019-11-12)** : Small updates, added new option "autoUploadEvents" to the sink.
* **Version 1.0.3.0 (2019-11-08)** : Updated nuget packages, added GitVersionTask.
* **Version 1.0.2.0 (2019-07-19)** : Support of role based authorization to S3 added, failureCallback parameter added.
* **Version 1.0.1.0 (2019-06-23)** : Added icon to the nuget package.
* **Version 1.0.0.0 (2019-05-31)** : 1.0 release.
# CodeChallenge

Big thanks to [Clean Architecture](https://github.com/ardalis/CleanArchitecture) for the starting template.

<hr>
The object model to expose via the ASP.NET Web API solution should have the following attributes only:<br>

:heavy_check_mark: Launchpad Id (maps to the “id” field from the SpaceX API)<br>
:heavy_check_mark: Launchpad Name (maps to the “full_name” field from the SpaceX API)<br>
:heavy_check_mark: Launchpad Status (maps to the “status” field from the SpaceX API)<br>
<hr>
:heavy_check_mark: Utilize the public API for SpaceX launchpad information:  https://api.spacexdata.com/v2/launchpads.<br>
:heavy_check_mark: Include some level of unit testing.<br>
:heavy_check_mark: Ensure there is some sort of logging.<br>
:heavy_check_mark: Ensure the application is configured via external configuration where it makes.<br>
:heavy_check_mark: Design the solution in such a way that that a database can later be used to replace the SpaceX REST API which incurs as little re-work/re-factor as possible.<br>
:heavy_check_mark: Make design decisions with the consideration that the service will be cloud hosted, need to be horizontally scalable, and will be potentially hosted within a microservice or SOA ecosystem.<br>
:heavy_check_mark: Functionality for consuming clients of the ASP.NET Core API endpoint(s) to apply filters in order to constrain the launchpad result set.  You can reference the SpaceX API documentation here for potential guidance:  https://github.com/r-spacex/SpaceX-API/wiki/Launchpad-Info<br>
<hr>
:heavy_check_mark: Display sound design concepts while demonstrating your knowledge of the C# language, .NET API’s, and any available 3rd party libraries.<br>
:heavy_check_mark: Creativity<br>
:heavy_check_mark: Efficiency<br>
:heavy_check_mark: Execution<br>
:heavy_check_mark: Another amazing team member!

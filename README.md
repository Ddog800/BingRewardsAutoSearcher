# MS Rewards Bing Auto Searcher

Uses the Selenium browser automated testing library to automatically perform 30 Bing searches from a pool of random search phrases. Implemented as a simple console app. It will immediately begin when the program is run.

## Instructions/Setup
There a few variables at the top of `Program.cs` that are used to configure some of the behavior:
- To run on a profile other than the default, modify `profileName`.
- To modify the number of searches to execute, modify `searchCount`.
- To modify the interval between searches, modify `searchIntervalMinSeconds` and `searchIntervalMaxSeconds`.

**Note**
All Edge processes much be **terminated** in order for it to be able to load the automation driver. Quickest way to do this is to close the Edge icon in your system tray. Otherwise, close the processes in Task Manager.

TODO: Check for existing Edge processes and offer to close them.
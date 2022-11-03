# Astral.Rest-Client
This is the windows client version of https://astral.rest/ which is a database lookup engine.

There will be 2 different text boxes when you open the client.

The first one is whatever you want to search, and the second box is where you put your PHPSESSID

If you do not know how to get your PHPSESSID, follow these steps.

1. Open Developer Tools
2. Go to the Network Tab
3. Search something and something should pop up. Something along the lines "search=query=" press that and scroll down.
4. Scrolldown to Request Headers -> Cookies and you will see something called "PHPSESSID=" you grab the string next to the "=" which would be something like "l0dkl1rd05bf74kr28cdjds0oa"
5. Have fun using it.

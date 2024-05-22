# OutSystems External Logic Library for parsing Open Graph Metadata

This external logic library wraps the opengraph-net library.

## Actions
The library exposes the following actions

### ParseOpenGraphUrl

Parses a given url and returns basic Open Graph metadata extracted from the page

**Input parameters**

* `url` - Full url to parse for Open Graph metadata
* `userAgent` - User Agent that is sent to the url as part of the request

**Result**

* `title` - Title of the page
* `description` - Description of the page
* `image` - Image Url
* `type` - Type of page
* `url` - Url of page


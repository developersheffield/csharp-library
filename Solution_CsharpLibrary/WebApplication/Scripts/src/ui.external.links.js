/*
 * Usage: Finds all links with a href starting with http and makes them safe
 * Add rel="internal" to any internal links that don't need to be made safe
 */
(function ($) {
    var externalLinks = {
        start: function () {
            $("a[href^='http']").each(function (i, el) {
                var $this = $(el);
                var rel = $this.attr("rel");
                var rels = !!rel ? rel.split(" ") : [];
				
                if (rels.indexOf("internal") > -1)
                    return true; // continue

				// prevent opened links from having JS access to opener
				// https://dev.to/ben/the-targetblank-vulnerability-by-example
				if (rels.indexOf("noopener") === -1)
					rels.push("noopener");
				if (rels.indexOf("noreferrer") === -1)
				    rels.push("noreferrer");
				$this.attr("rel", rels.join(" "));
			});	
        }
    };

    $(externalLinks.start);
}(jQuery));
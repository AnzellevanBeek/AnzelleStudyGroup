document.addEventListener("DOMContentLoaded", function () {
    let links = document.querySelectorAll("a");

    let activeLink = localStorage.getItem("activeLink");
    if (activeLink) {
        document.querySelectorAll("a").forEach(link => {
            if (link.href === activeLink) {
                link.classList.add("active");
            }
        });
    }

    links.forEach(link => {
        link.addEventListener("click", function () {
            links.forEach(l => l.classList.remove("active")); // Remove active from all
            this.classList.add("active"); // Add active to clicked link
            localStorage.setItem("activeLink", this.href);
        });
    });
});

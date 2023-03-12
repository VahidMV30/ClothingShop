$(function () {
  //Get system default theme or local storage theme
  if (
    localStorage.theme === "dark" ||
    (!("theme" in localStorage) && window.matchMedia("(prefers-color-scheme: dark)").matches)
  ) {
    document.documentElement.classList.add("dark");
    localStorage.removeItem("theme");
    localStorage.theme = "dark";
  } else {
    document.documentElement.classList.remove("dark");
    localStorage.removeItem("theme");
    localStorage.theme = "light";
  }

  // Toggle dark or light mode when button is clicked
  $(".dark-light-toggler-btn").on("click", function () {
    if (localStorage.theme === "dark") {
      document.documentElement.classList.remove("dark");
      localStorage.removeItem("theme");
      localStorage.theme = "light";
    } else {
      document.documentElement.classList.add("dark");
      localStorage.removeItem("theme");
      localStorage.theme = "dark";
    }
  });

  $(".admin-sidebar-toggler-btn").on("click", function () {
    $(".admin-header").toggleClass("admin-header-resize");
    $(".admin-sidebar-backdrop").toggleClass("admin-sidebar-backdrop-toggle");
    $(".admin-sidebar").toggleClass("admin-sidebar-toggle");
    $(".admin-brand-title").toggleClass("admin-brand-title-scale");
    $(".admin-sidebar-brand").toggleClass("admin-sidebar-brand-rotate");
    $(".admin-sidebar-toggler-btn-circle").toggleClass("admin-sidebar-toggler-btn-circle-rotate");
    $(".admin-sidebar-navs a span").toggleClass("admin-sidebar-navs-title-scale");
    $(".admin-main-content").toggleClass("admin-main-content-resize");
  });

  $(".admin-sidebar-backdrop").on("click", function () {
    $(this).toggleClass("admin-sidebar-backdrop-toggle");
    $(".admin-sidebar").toggleClass("admin-sidebar-toggle");
  });
});

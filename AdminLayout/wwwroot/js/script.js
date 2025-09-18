const ctx = document.getElementById("salesChart").getContext("2d");
new Chart(ctx, {
  type: "bar",
  data: {
    labels: [
      "Jan",
      "Feb",
      "Mar",
      "Apr",
      "May",
      "Jun",
      "Jul",
      "Aug",
      "Sep",
      "Oct",
      "Nov",
      "Dec",
    ],
    datasets: [
      {
        data: [150, 380, 200, 280, 180, 190, 270, 120, 210, 360, 250, 130],
        backgroundColor: "#4f46e5",
      },
    ],
  },
  options: {
    plugins: { legend: { display: false } },
    scales: {
      x: { grid: { display: false }, ticks: { color: "#94a3b8" } },
      y: { ticks: { color: "#94a3b8" }, grid: { color: "#334155" } },
    },
    responsive: true,
    maintainAspectRatio: false,
  },
});

const gaugeCtx = document.getElementById("gaugeChart").getContext("2d");
new Chart(gaugeCtx, {
  type: "doughnut",
  data: {
    datasets: [
      {
        data: [75, 25],
        backgroundColor: ["#4f46e5", "#334155"],
        cutout: "80%",
      },
    ],
  },
  options: {
    plugins: { legend: { display: false } },
    circumference: 180,
    rotation: 270,
  },
  responsive: true,
  maintainAspectRatio: false,
});

const sidebar = document.getElementById("sidebar");
const menuBtn = document.getElementById("menuBtn");

menuBtn.addEventListener("click", () => {
  sidebar.classList.toggle("hidden");
});

document.addEventListener("click", (e) => {
  if (!sidebar.contains(e.target) && !menuBtn.contains(e.target)) {
    sidebar.classList.add("hidden");
  }
});

sidebar.addEventListener("mouseleave", () => {
  if (window.innerWidth < 1024) {
    sidebar.classList.add("hidden");
  }
});

window.addEventListener("resize", () => {
  if (window.innerWidth < 1024) {
    sidebar.classList.add("hidden");
  }
});

function initializeCaseStatusChart(canvasId, data) {
    const ctx = document.getElementById(canvasId).getContext('2d');
    new Chart(ctx, {
        type: 'doughnut',
        data: {
            labels: ['Open', 'Closed', 'Pending'],
            datasets: [{
                data: [data.Open, data.Closed, data.Pending],
                backgroundColor: [
                    '#4e73df',
                    '#1cc88a',
                    '#f6c23e'
                ]
            }]
        },
        options: {
            responsive: true,
            plugins: {
                legend: {
                    position: 'bottom'
                }
            }
        }
    });
}

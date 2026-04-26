const baseUrl = "http://localhost:5053/api";

// Add Food
function addFood() {
    fetch(`${baseUrl}/food`, {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({
            id: parseInt(document.getElementById("foodId").value),
            name: document.getElementById("foodName").value,
            price: parseFloat(document.getElementById("foodPrice").value)
        })
    })
        .then(res => res.json())
        .then(data => alert("Food Added!"));
}


function getFoods() {
    fetch(`${baseUrl}/foods`)
        .then(res => res.json())
        .then(data => {
            let output = "";

            data.forEach(f => {
                output += `
                <p>
                    ${f.id} | ${f.name} | ₹${f.price}
                </p>
            `;
            });

            document.getElementById("foods").innerHTML = output;
        });
}


// Place Order
function placeOrder() {
    fetch(`${baseUrl}/order`, {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify([
            {
                foodId: parseInt(document.getElementById("orderFoodId").value),
                quantity: parseInt(document.getElementById("quantity").value)
            }
        ])
    })
        .then(res => res.json())
        .then(data => alert("Order Placed! Total: " + data.totalBill));
}

// Get Orders
function getOrders() {
    fetch(`${baseUrl}/orders`)
        .then(res => res.json())
        .then(data => {
            let output = "";
            data.forEach(o => {
                output += `<p>Order ID: ${o.id} | Total: ₹${o.totalBill}</p>`;
            });
            document.getElementById("orders").innerHTML = output;
        });
} 
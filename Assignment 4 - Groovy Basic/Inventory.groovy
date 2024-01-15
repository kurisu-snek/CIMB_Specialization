class StoreInventory {
    private List<Map<String, Object>> items = []

    void manageInventory() {
        println "How many items do you want to add to the inventory?"
        int itemCount
        try {
            itemCount = System.in.newReader().readLine().toInteger()
        } catch (NumberFormatException e) {
            println "Error: Please enter a valid integer for the item count."
            return
        }

        for (int i = 1; i <= itemCount; i++) {
            println "Adding item $i"
            try {
                print "Enter item ID: "
                String id = System.in.newReader().readLine()
                print "Enter item name: "
                String name = System.in.newReader().readLine()
                print "Enter item price: "
                BigDecimal price = System.in.newReader().readLine().toBigDecimal()
                print "Enter item stock: "
                int stock = System.in.newReader().readLine().toInteger()

                addItem(id, name, price, stock)
                println "Item $i added successfully."
            } catch (NumberFormatException e) {
                println "Error: Please enter a valid number for price or stock."
                i-- // Decrement i to re-attempt the current item input
            }
        }

        displayItems()
        calculateTotalValue()
    }

    private void addItem(String id, String name, BigDecimal price, int stock) {
        Map<String, Object> item = [
            'ID'    : id,
            'Name'  : name,
            'Price' : price,
            'Stock' : stock
        ]
        items << item
    }

    private void displayItems() {
        println "\nInventory List:"
        items.each { item ->
            println "ID: ${item['ID']}, Name: ${item['Name']}, Price: \$${item['Price']}, Stock: ${item['Stock']}"
        }
    }

    private void calculateTotalValue() {
        BigDecimal totalValue = items.sum { it['Price'] * it['Stock'] }
        println "\nTotal value of stock inventory: \$${totalValue}"
    }
}

// Example usage
new StoreInventory().manageInventory()

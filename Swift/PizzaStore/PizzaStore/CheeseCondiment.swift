import Foundation

class CheeseCondiment: Condiments{
    var costCheese: Double = 0.5
    override init(){
        super.init()
        name = "Сыр"
        description = "Нежный сыр"
    }
}

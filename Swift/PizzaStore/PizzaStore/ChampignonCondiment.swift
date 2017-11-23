import Foundation

class ChampignonCondiment: Condiments{
    var costChampignon: Double = 0.7
    
    override init(){
        super.init()
        name = "Шампиньоны"
        description = "Грибочки"
    }
}

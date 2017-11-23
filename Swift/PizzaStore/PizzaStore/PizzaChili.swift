import Foundation

class PizzaChili: Pizza{
    
    override init(){
        super.init()
        costSmall = 1
        costMedium = 2
        costBig = 3
        name = "Чили"
        description = "Пицца с перчиком"
        nameOfImage = "pizzaChili"
        decsriptionSmall = "Маленькая пицца с перчиком"
        descriptionMedium = "Средняя пицца с перчиком"
        descriptionBig = "Большая пицца с перчиком"    }
}

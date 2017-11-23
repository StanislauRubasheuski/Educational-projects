import Foundation

class PizzaPepperoni: Pizza{
    
    override init(){
       super.init()
        costSmall = 4
        costMedium = 5
        costBig = 6
        name = "Пепперони"
        nameOfImage = "pizzaPepperoni"
        decsriptionSmall = "Маленькая пицца с колбасками"
        descriptionMedium = "Средняя пицца с колбасками"
        descriptionBig = "Большая пицца с колбасками"
        description = "Пицца с колбасками"
        
    }
}

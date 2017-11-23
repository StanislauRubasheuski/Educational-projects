import UIKit

class ViewController: UIViewController {

    @IBOutlet weak var pizzaSegment: UISegmentedControl!
    @IBOutlet weak var pizzaImages: UIImageView!
    @IBOutlet weak var sizeSegment: UISegmentedControl!
    @IBOutlet weak var pizzaDescription: UITextView!
    @IBOutlet weak var cheeseSwitch: UISwitch!
    @IBOutlet weak var champignonSwitch: UISwitch!
    @IBOutlet weak var labelOfButtonAction: UILabel!
    @IBOutlet weak var labelOfSum: UILabel!
    var pizzaChili = PizzaChili()
    var pizzaPeperoni = PizzaPepperoni()
    var pizzaHawaii = PizzaHawaii()
    var pizza: Pizza = Pizza()
    var cheese = CheeseCondiment()
    var champignon = ChampignonCondiment()
    var sum: Double = 0
    
    override func viewDidLoad() {
        super.viewDidLoad()
        pizza = pizzaChili
        pizzaImages.image = UIImage(named: "\(pizza.nameOfImage)")
        pizzaDescription.text = pizza.description
        pizza.costPizza = pizza.costSmall
        sum = pizza.costPizza + cheese.cost + champignon.cost
        labelOfSum.text = String(sum)
    }

    @IBAction func pizzaActionSegment(_ sender: Any) {
        switch pizzaSegment.selectedSegmentIndex{
        case 1:
            pizza = pizzaPeperoni
            pizzaImages.image = UIImage(named: "\(pizza.nameOfImage)")
            pizza.description = pizza.description
            pizza.costPizza = pizza.costPizza
            pizzaDescription.text = pizza.description
            sum = pizza.costPizza + cheese.cost + champignon.cost
            labelOfSum.text = String(sum)
        case 2:
            pizza = pizzaHawaii
            pizzaImages.image = UIImage(named: "\(pizza.nameOfImage)")
            pizza.description = pizza.description
            pizzaDescription.text = pizza.description
            pizza.costPizza = pizza.costPizza
            sum = pizza.costPizza + cheese.cost + champignon.cost
            labelOfSum.text = String(sum)
        default:
            pizza = pizzaChili
            pizzaImages.image = UIImage(named: "\(pizza.nameOfImage)")
            pizza.description = pizza.description
            pizzaDescription.text = pizza.description
            pizza.costPizza = pizza.costPizza
            sum = pizza.costPizza + cheese.cost + champignon.cost
            labelOfSum.text = String(sum)
        }
    }
    @IBAction func sizeSegment(_ sender: Any) {
        switch sizeSegment.selectedSegmentIndex{
        case 1:
            pizza.description = pizza.descriptionMedium
            pizza.costPizza = pizza.costMedium
            pizzaDescription.text = pizza.description
            sum = pizza.costPizza + cheese.cost + champignon.cost
            labelOfSum.text = String(sum)
        case 2:
            pizza.description = pizza.descriptionBig
            pizza.costPizza = pizza.costBig
            pizzaDescription.text = pizza.description
            sum = pizza.costPizza + cheese.cost + champignon.cost
            labelOfSum.text = String(sum)
        default:
            pizza.description = pizza.decsriptionSmall
            pizza.costPizza = pizza.costSmall
            pizzaDescription.text = pizza.description
            sum = pizza.costPizza + cheese.cost + champignon.cost
            labelOfSum.text = String(sum)
            
        }
    }
    
    @IBAction func cheeseActionSwitch(_ sender: Any) {
        if cheeseSwitch.isOn{
            cheese.cost = cheese.costCheese
            sum = pizza.costPizza + cheese.cost + champignon.cost
            labelOfSum.text = String(sum)
            
        }
        else {
            cheese.cost = 0
            sum = pizza.costPizza + cheese.cost + champignon.cost
            labelOfSum.text = String(sum)
            
        }
    }
    
    @IBAction func champignonActionSwitch(_ sender: Any) {
        if champignonSwitch.isOn {
            champignon.cost = champignon.costChampignon
            sum = pizza.costPizza + cheese.cost + champignon.cost
            labelOfSum.text = String(sum)
            
        }
        else {
            champignon.cost = 0
            sum = pizza.costPizza + cheese.cost + champignon.cost
            labelOfSum.text = String(sum)
            
        }
    }
    
    @IBAction func buttonAction(_ sender: Any) {
        labelOfButtonAction.text = "Ваш заказ принят. Итого: \(sum)"
    }
    
}


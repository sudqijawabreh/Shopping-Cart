// Learn more about F# at http://fsharp.org. See the 'F# Tutorial' project
// for more guidance on F# programming.

#load "Library1.fs"
open Shopping_Cart
// Define your library scripting code here
type Id =int
type Name=string
type Price=decimal
type Item=
    {
        id:Id
        name:Name
        price:Price
    }
type Cart=
    {
        items:Item list
        id:Id
    }

type User=
    {
        id:Id
        name:Name
        cart:Cart
    }
let addItem cart item =
    let items=item::cart.items
    {cart with items=items}
let buyItems cart=
    {cart with items=[]}



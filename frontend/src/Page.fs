module DoCSoc.Page
open Fable.React

type Page = {
  Path: string
  Name: string
  Element: ReactElement
}

let home = {Path = ""; Name = "home"; Element = div [] [str "Hello World!"]}
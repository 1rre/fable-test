module DoCSoc.Components.Hero

open Fable.React
open Fable.React.Props
open Types

let navlink model href elem =
  let extraClasses = if model.CurrentPage.Path = href then " active" else ""
  li [ClassName ("navigation__link" + extraClasses)] [a [Href href] [elem]]

let navlinkClass = ClassName "navigation__link"

let navlinks model dispatch =
  let x = Utils.resolve "../../data/navlinks"
  printfn $"{x}"
  [
  navlink model "/sponsors" <| str "Sponsors"
  navlink model "/about" <| str "About"
  navlink model "/portal" <| str "Portal"
  navlink model "/blog" <| str "Blog"
  li [ClassName "dropdown"] [
    div [ClassName "dropdown__label"] [str "More ▾"]
    ul [ClassName "dropdown__submenu"] [
      navlink model "/documents" <| str "Documents"
      navlink model "/blog" <| str "Education"
      navlink model "/blog" <| str "Software Foundation"
      navlink model "/blog" <| str "Services"

    ] ]
  navlink model "/facebook" <| str "Facebook"
]

let hero model dispatch =
  header [ClassName "hero u-cf"] [
    div [ClassName "stripe u-cf"] [
      nav [ClassName "container hero__blog u-cf"] [
        div [ClassName "hero__blog__logo u-cf u-pull-start"] [
          a [Href ""] [img [
              Src "https://d33wubrfki0l68.cloudfront.net/ae969c99f655993c0c12a272626abba129e3b112/adbf3/img/imperial-docsoc-logo.png"
              HTMLAttr.Width "150px" ] ] ]
        ul [ClassName "navigation"] <| navlinks model dispatch ] ] ]
module App.State

open Elmish
open Elmish.Navigation
open Elmish.UrlParser
open Browser
open DoCSoc.Page
open Types

let pageParser: Parser<Page->Page,Page> =
    oneOf [
        map home (s home.Path)
    ]

let urlUpdate (result : Page option) model =
    match result with
    | None ->
        console.error("Error parsing url")
        model, Navigation.modifyUrl (model.CurrentPage.Path)
    | Some page ->
        { model with CurrentPage = page }, []

let init result =
    let (model, cmd) =
        urlUpdate result
          { CurrentPage = home }

    model, cmd

let update msg model =
    model, Cmd.none
import React from 'react'
import {AppContext} from '../App/AppProvider'
export default function(props) {
    return <AppContext.Consumer>
        {({}) => {
            return <div>{props.children}</div> 
        }}
    </AppContext.Consumer>

}
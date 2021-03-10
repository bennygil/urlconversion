import React from 'react'
import styled from 'styled-components'
import { fontSize2, fontSize3 } from '../Shared/Styles' 
import {AppContext} from '../App/AppProvider'

const ItemTitle = styled.div`
    ${fontSize2};
`
const ItemString = styled.div`
    ${fontSize3};
`

const ScrollContainer = styled.div`
    overflow:scroll;
    height: 200px;
`

export default function({website, index})
{
    return (
        <AppContext.Consumer>
        {({}) => 
        <tr>
            <td>
                <ItemTitle>
                    { website.name }
                </ItemTitle>
            </td>
            <td>
                <ScrollContainer>
                    <ItemString>
                       { website.htmlString }
                    </ItemString>
                </ScrollContainer>
            </td>
        </tr>
    }
    </AppContext.Consumer>
    )
}
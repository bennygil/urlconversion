import React from 'react'
import styled from 'styled-components';
import Table from 'react-bootstrap/Table'
import { AppContext } from '../App/AppProvider'

const List = styled.ul`    
    height:420px;
    overflow: auto;
    padding: 0px;
`

function WebsiteList() {
    return (
    <AppContext.Consumer>
        {({ websites }) => (
            <List>
                { websites.length === 0 ? 
                    <Table striped bordered hover size="sm">
                        <thead>
                            <tr>
                                <th>Site Url</th>
                                <th>Website Html Content</th>
                            </tr>
                        </thead>
                    </Table> :
                    <div>No Websites have been selected for conversion yet.</div>                    
                }
            </List>
        )}
    </AppContext.Consumer>
    )
}

export default WebsiteList
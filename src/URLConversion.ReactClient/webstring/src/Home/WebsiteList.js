import React from 'react'
import styled from 'styled-components';
import Table from 'react-bootstrap/Table'
import { AppContext } from '../App/AppProvider'
import WebsiteItem from './WebsiteItem';
import { Tile } from '../Shared/Tile';

const List = styled.ul`    
    height:420px;
    overflow: auto;
    padding: 0px;
`

function WebsiteList() {
    return (
    <AppContext.Consumer>
        {({ websites }) => (
            <Tile>
            <List>
                { websites.length != 0 ? 
                    <Table striped bordered hover size="sm">
                        <thead>
                            <tr>
                                <th>Site Url</th>
                                <th>Website Html Content</th>
                            </tr>
                        </thead>
                        <tbody>
                            { websites.map((website, index) => <WebsiteItem key={`websiteItem-${index}` } index={index} website={website} /> )}
                        </tbody>
                    </Table> :
                    <div>No Websites have been selected for conversion yet.</div>                    
                }
            </List>
            </Tile>
        )}
    </AppContext.Consumer>
    )
}

export default WebsiteList
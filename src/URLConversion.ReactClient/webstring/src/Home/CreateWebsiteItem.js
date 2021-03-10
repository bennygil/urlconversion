import React from 'react';
import { AppContext } from '../App/AppProvider';
import { Form, Card, Button } from 'react-bootstrap';
import * as apiService from '../Services/apiService'
import { Tile } from '../Shared/Tile';


const addWebsite = async (e, websites) => {
    e.preventDefault();
    const form = e.currentTarget;
    if(form.checkValidity() === false) {
        e.stopPropagation();
    }
    const formData = new FormData(form);
  var convertedSite = await apiService.convertWebsite({
        "website" : formData.get('websiteUrl')
    });
    console.log(convertedSite)
    websites.push(convertedSite)
}

export default function() {
    return (
        <AppContext.Consumer>
            {({websites}) => (
            <Tile>
                <div className="modal-wrapper">
                <Card>
                    <Card.Body>
                        <Form onSubmit={event => addWebsite(event, websites)}>
                            <Form.Group controlId="websiteUrl">
                                <Form.Label>Website Url</Form.Label>
                                <Form.Control required name="websiteUrl" text="text" placeholder="Enter Website Name"></Form.Control>
                            </Form.Group>
                            <Button variant="success" type="submit">Add Website</Button>
                        </Form>
                    </Card.Body>
                </Card>
                </div>
                </Tile>
            )}
        </AppContext.Consumer>
    )
}
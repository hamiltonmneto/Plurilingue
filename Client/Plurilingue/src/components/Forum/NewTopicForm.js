//import liraries
import React, { Component } from 'react';
import { View, Text, StyleSheet, Dimensions} from 'react-native';
import { Container, Header, Content, Form, Item, Input, Label, Icon, Button, Textarea } from 'native-base';

// create a component
const {width: WIDTH} = Dimensions.get('window')
const {height: HEIGHT} = Dimensions.get('window')
class NewTopicForm extends Component {
    render() {
        return (
            <Container>
                <Content>
                    <Form style={{marginTop: 50}}>
                        <Item rounded>
                            <Input placeholder='Title' />
                        </Item>
                        <Item rounded>
                            <Input placeholder='Language'/>
                        </Item>

                        <Textarea rowSpan={5} bordered placeholder="Textarea" />

                    </Form>
                    <Button block danger onPress={() => this.submit()} style={{width: WIDTH - 100, marginTop: 60, justifyContent: 'center', left: 50}}>
                        <Text style={{fontSize: 18, color: 'white', fontWeight: 'bold'}}>Post Your Question</Text>
                    </Button>
                </Content>
            </Container>
        );
    }
}

// define your styles
const styles = StyleSheet.create({
    container: {
        flex: 1,
        justifyContent: 'center',
        alignItems: 'center',
        backgroundColor: '#fff',
    },
});

//make this component available to the app
export default NewTopicForm;
